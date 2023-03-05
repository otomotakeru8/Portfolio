using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AnimationConstant;

public class CustomAnimation : MonoBehaviour
{
    [SerializeField]
    public float m_baseAnimationSpeed;
    [SerializeField]
    bool m_oneShot;
    [SerializeField]
    public SimpleAnimation[] m_simpleAnimations;
    [SerializeField]
    public JointAnimation[] m_jointAnimations;

    float m_timeLine;
    float m_direction;

    // Start is called before the first frame update
    void Start()
    {
        m_direction = 1;
        for (int i = 0; i < m_simpleAnimations.Length; i++)
        {
            m_simpleAnimations[i].m_defaultTransform = m_simpleAnimations[i].m_target.transform;
        }
        for (int i = 0; i < m_jointAnimations.Length; i++)
        {
            m_jointAnimations[i].m_defaultTransform = m_jointAnimations[i].m_target.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_timeLine += Time.deltaTime * m_baseAnimationSpeed;
        if (m_timeLine > 0.5f)
        {
            m_direction = -1;
        }
        if (m_timeLine > 1)
        {
            m_direction = 1;
            m_timeLine = 0;
            if (m_oneShot == true)
            {
                m_baseAnimationSpeed = 0;
            }
        }
        if (m_simpleAnimations.Length != 0)
        {
            for (int i = 0; i < m_simpleAnimations.Length; i++)
            {
                if (m_timeLine == 0)
                {
                    m_simpleAnimations[i].m_target.transform.position = m_simpleAnimations[i].m_defaultTransform.position;
                }
                Animation_Simple(m_simpleAnimations[i]);
            }
        }
        if (m_jointAnimations.Length != 0)
        {
            for (int i = 0; i < m_jointAnimations.Length; i++)
            {
                if (m_timeLine == 0)
                {
                    m_jointAnimations[i].m_target.transform.position = m_jointAnimations[i].m_defaultTransform.position;
                }
                Animation_Joint(m_jointAnimations[i]);
            }
        }
    }

    void Animation_Simple(SimpleAnimation animationData)
    {
        float moveValue = animationData.m_moveValue * (Time.deltaTime * m_baseAnimationSpeed * animationData.m_animationSpeed * m_direction);
        switch (animationData.m_simpleAnimationPattern)
        {
            case SimpleAnimationPattern.MoveX:
                if (animationData.m_local == true)
                {
                    animationData.m_target.transform.Translate(moveValue, 0, 0);
                }
                else
                {
                    animationData.m_target.transform.Translate(moveValue, 0, 0, Space.World);
                }
                break;
            case SimpleAnimationPattern.MoveY:
                if (animationData.m_local == true)
                {
                    animationData.m_target.transform.Translate(0, moveValue, 0);
                }
                else
                {
                    animationData.m_target.transform.Translate(0, moveValue, 0, Space.World);
                }
                break;
            case SimpleAnimationPattern.MoveZ:
                if (animationData.m_local == true)
                {
                    animationData.m_target.transform.Translate(0, 0, moveValue);
                }
                else
                {
                    animationData.m_target.transform.Translate(0, 0, moveValue, Space.World);
                }
                break;
            case SimpleAnimationPattern.RotateX:
                animationData.m_target.transform.Rotate(moveValue, 0, 0);
                break;
            case SimpleAnimationPattern.RotateY:
                animationData.m_target.transform.Rotate(0, moveValue, 0);
                break;
            case SimpleAnimationPattern.RotateZ:
                animationData.m_target.transform.Rotate(0, 0, moveValue);
                break;
        }
    }

    void Animation_Joint(JointAnimation animationData)
    {
        float moveValue = animationData.m_moveValue * (Time.deltaTime * m_baseAnimationSpeed * m_direction);
        switch (animationData.m_jointAnimationPattern)
        {
            case JointAnimationPattern.RotateX:
                animationData.m_target.transform.RotateAround(animationData.m_joint.transform.position, transform.right, moveValue);
                break;
            case JointAnimationPattern.RotateY:
                animationData.m_target.transform.RotateAround(animationData.m_joint.transform.position, transform.up, moveValue);
                break;
            case JointAnimationPattern.RotateZ:
                animationData.m_target.transform.RotateAround(animationData.m_joint.transform.position, transform.forward, moveValue);
                break;
        }
    }
}
