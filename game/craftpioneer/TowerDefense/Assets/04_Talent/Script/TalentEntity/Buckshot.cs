using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buckshot : MonoBehaviour
{
    [SerializeField]
    GameObject Bullet;
    [SerializeField]
    int m_multciply = 5;
    [SerializeField]
    float m_spread = 15;

    List<GameObject> talentInstanceObject = new List<GameObject>();
    private void Start()
    {
        StartCoroutine(nameof(enumerator));
    }
    IEnumerator enumerator()
    {
        yield return null;
        for (int i = 0; i < m_multciply; i++)
        {
            Vector2 spreaded = (m_spread / 180f) * UnityEngine.Random.insideUnitCircle;
            Quaternion quaternion = transform.rotation;
            quaternion.eulerAngles += new Vector3(spreaded.x, spreaded.y, 0);
            talentInstanceObject.Add(Instantiate(Bullet, transform.position, quaternion));
        }
        Talent talent = GetComponent<Talent>();
        Velocity velocity = GetComponent<Velocity>();
        for (int i = 0; i < talentInstanceObject.Count; i++)
        {
            Talent instanceTalent = talentInstanceObject[i].GetComponent<Talent>();
            instanceTalent.SetStates(talent.m_damage, 0, talent.Speed, talent.m_lifeTime, false, transform.rotation.eulerAngles, velocity.m_airResistance, velocity.m_massScale);
        }
        Destroy(this.gameObject);
    }
}
