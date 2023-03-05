using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EffectConstant;

public class Effect : MonoBehaviour
{
    [SerializeField]
    GameObject m_fire;
    [SerializeField]
    GameObject m_toxic;
    [SerializeField]
    GameObject m_electric;
    [SerializeField]
    GameObject m_ice;

    List<StatusEffect> m_materialEffect = new List<StatusEffect>();
    Talent m_talent;

    public void AddEffect(StatusEffect effect)
    {
        m_materialEffect.Add(effect);
        m_talent = transform.parent.GetComponent<Talent>();
        m_talent.AddEvent(effect);
    }

    private void Update()
    {
        foreach (StatusEffect effect in m_materialEffect)
        {
            switch (effect)
            {
                case StatusEffect.fire:
                    //エフェクトを出す
                    break;
                case StatusEffect.toxic:

                    break;
                case StatusEffect.electric:

                    break;
                case StatusEffect.ice:

                    break;
            }
        }
    }
}
