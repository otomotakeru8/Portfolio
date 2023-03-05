using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static AnimationConstant;

[Serializable]
public class JointAnimation
{
    [SerializeField]
    public JointAnimationPattern m_jointAnimationPattern;
    [SerializeField]
    public float m_animationSpeed;
    [SerializeField]
    public GameObject m_target;
    [SerializeField]
    public GameObject m_joint;
    [SerializeField]
    public float m_moveValue;
    [HideInInspector]
    public Transform m_defaultTransform;
}
