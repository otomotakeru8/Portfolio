using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static AnimationConstant;

[Serializable]
public class SimpleAnimation
{
    [SerializeField]
    public SimpleAnimationPattern m_simpleAnimationPattern;
    [SerializeField]
    public float m_animationSpeed;
    [SerializeField]
    public GameObject m_target;
    [SerializeField]
    public float m_moveValue;
    [SerializeField]
    public bool m_local;
    [HideInInspector]
    public Transform m_defaultTransform;
}
