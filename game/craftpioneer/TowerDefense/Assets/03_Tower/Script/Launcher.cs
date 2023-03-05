using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static Utilities;

public class Launcher : MonoBehaviour
{
    Tower m_tower;
    CapsuleCollider m_sphereCollider;

    [SerializeField]
    GameObject[] m_talentObjects;
    Quaternion m_aimAxis;

    private void Start()
    {
        m_tower = transform.parent.GetComponent<Tower>();
        m_sphereCollider = GetComponent<CapsuleCollider>();
    }

    public void SetRange(float value)
    {
        if (m_sphereCollider == null)
        {
            m_sphereCollider = GetComponent<CapsuleCollider>();
        }
        m_sphereCollider.radius = value;
    }

    public void ShotAction(List<TalentBase> talentBases, float spread)
    {
        Type type = Type.GetType("TalentActions");
        object temporary = Activator.CreateInstance(type);
        List<MethodInfo> methodInfos = new List<MethodInfo>();

        foreach (TalentBase talentBase in talentBases)
        {
            if (talentBase.m_shooterInformation == 0)
            {
                try
                {
                    methodInfos.Add(type.GetMethod(talentBase.m_talentName + "Action"));
                }
                catch (Exception e)
                {
                    Debug.LogError(e.Message);
                }
            }
        }

        //é¿ëÃÇéùÇΩÇ»Ç¢í≤êÆî’ÇèúäO
        for (int i = 0; i < talentBases.Count; i++)
        {
            if (CheckNullData(talentBases[i]) == true || talentBases[i].m_talentType == TalentConstant.TalentType.Modifier)
            {
                talentBases.RemoveAt(i);
            }
        }

        List<GameObject> talentInstanceObject = new List<GameObject>();
        foreach (TalentBase talent in talentBases)
        {
            foreach (GameObject talentObject in m_talentObjects)
            {
                if (talentObject.name.Equals(talent.m_talentName))
                {
                    talentInstanceObject.Add(talentObject);
                }
            }
        }

        talentInstanceObject = Shot(talentInstanceObject, spread);

        for (int i = 0; i < talentInstanceObject.Count; i++)
        {
            Talent talent = talentInstanceObject[i].GetComponent<Talent>();
            talent.SetStates(talentBases[i].m_damage, 0, talentBases[i].m_speed, talentBases[i].m_lifeTime, talentBases[i].m_pierceing, transform.rotation.eulerAngles, talentBases[i].m_airResistance, talentBases[i].m_massScale);
            MethodInfo info = type.GetMethod("SetObject");
            info.Invoke(temporary, new object[]{talentInstanceObject[i]});
            if (methodInfos != null)
            {
                foreach (MethodInfo methodinfo in methodInfos)
                {
                    methodinfo?.Invoke(temporary, null);
                }
            }
        }
    }

    public List<GameObject> Shot(List<GameObject> castObjects, float spread)
    {
        List<GameObject> returnObject = new List<GameObject>();
        foreach (GameObject shotObject in castObjects)
        {
            Vector2 spreaded = (spread / 180.0f) * UnityEngine.Random.insideUnitCircle;
            m_aimAxis.eulerAngles += new Vector3(spreaded.x, spreaded.y, 0);
            returnObject.Add(Instantiate(shotObject, transform.position, m_aimAxis, null));
        }
        return returnObject;
    }

    public void Aiming(Transform target)
    {
        Vector3 targetPos = target.position + new Vector3(0, 0.2f, 0);
        m_aimAxis = Quaternion.FromToRotation(transform.forward, targetPos - transform.position);
    }

    private void OnTriggerStay(Collider other)
    {
        if (m_tower.m_onReCherge == false)
        {
            if (other.tag.Contains("Enemy") == true)
            {
                m_tower.m_onReCherge = true;
                Aiming(other.transform);
                m_tower.DrawAction(1);
                m_tower.PlayAction();
            }
        }
    }
}
