using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainGameCharacterState;
using static Constant;

public class PlayerSkill : MonoBehaviour
{
    public bool m_skillActivating;
    public int m_skillCoolDown;
    public int m_skillCoolTime;
    public bool m_skillEnabled;
    public bool m_lateSkillEnabled;
    public int m_skillStack;
    int m_maxSkillStack;

    [SerializeField]
    public PlayerSkillData m_playerSkillData;

    public SkillEvent m_skillEvent;

    public MainGame m_mainGame;
    public Player m_player;
    public int m_skillLevel;

    public void SkillCoolTimeCounter()
    {
        if (m_skillCoolTime > 0)
        {
            m_skillCoolTime--;
            if (m_skillCoolTime == 0)
            {
                m_skillEnabled = true;
                m_skillStack++;
                if (m_skillStack < m_maxSkillStack)
                {
                    m_skillCoolTime = m_skillCoolDown;
                }
            }
        }
    }

    void Skill()
    {
        MainGameCharacterModel[] target;
        if (m_playerSkillData.m_originalAttackRange == true)
        {
            if (m_playerSkillData.m_type == PlayerSkillData.SkillTargetingType.Attack)
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_playerSkillData.m_attackRange, false, true, false);
            }
            else
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_playerSkillData.m_attackRange, true, false, false);
            }
        }
        else
        {
            if (m_playerSkillData.m_type == PlayerSkillData.SkillTargetingType.Attack)
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_player.attackRange, false, true, false);
            }
            else
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_player.attackRange, true, false, false);
            }
        }
        
        
        foreach (MainGameCharacterModel targetCharacter in target)
        {
            if (m_playerSkillData.m_stan == true)
            {
                StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(targetCharacter, m_playerSkillData.m_stanTimeData, Stan));
                void Stan()
                {
                    targetCharacter.charactorState = CharacterState.Stan;
                }
            }
            if (m_playerSkillData.m_attackSkill.Length > 0)
            {
                for (int i = 0; i < m_playerSkillData.m_attackSkill.Length; i++)
                {
                    StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(targetCharacter, m_playerSkillData.m_attackSkill[i].m_timerData, PlayerSkillAttack));
                    void PlayerSkillAttack()
                    {
                        double damageMagnification = m_playerSkillData.m_attackSkill[i].m_damageMagnification + m_playerSkillData.m_attackSkill[i].m_increaseDamageMagnification * (m_skillLevel - 1);
                        Damage damage = new Damage(
                            m_playerSkillData.m_attackSkill[i].m_damageType, (int)(m_player.baseAttackPower * damageMagnification));
                        targetCharacter.TakeDamage(damage);
                    }
                }
            }
            if (m_playerSkillData.m_buffskill.Length > 0)
            {
                for (int i = 0; i < m_playerSkillData.m_buffskill.Length; i++)
                {
                    StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(targetCharacter, m_playerSkillData.m_buffskill[i].m_timerData, PlayerSkillBuff));
                    void PlayerSkillBuff()
                    {
                        float ratio = m_playerSkillData.m_buffskill[i].m_ratio + m_playerSkillData.m_buffskill[i].m_increaseRatio * (m_skillLevel - 1);
                        switch (m_playerSkillData.m_buffskill[i].m_buffType)
                        {
                            case BuffSkill.BuffType.Healing:
                                targetCharacter.Healing((int)(m_player.maxHp * ratio));
                                break;
                            case BuffSkill.BuffType.AddAttackSpeed:
                                targetCharacter.addAttackCooldownRatio = ratio;
                                break;
                        }
                    }
                }
            }
            if (m_playerSkillData.m_debuffSkill.Length > 0)
            {
                for (int i = 0; i < m_playerSkillData.m_debuffSkill.Length; i++)
                {
                    StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(targetCharacter, m_playerSkillData.m_debuffSkill[i].m_timerData, PlayerSkillDebuff));
                    void PlayerSkillDebuff()
                    {
                        switch (m_playerSkillData.m_debuffSkill[i].m_debuffType)
                        {
                            case DebuffSkill.DebuffType.Speed:
                                targetCharacter.addMoveSpeedRatio = m_playerSkillData.m_debuffSkill[i].m_ratio;
                                break;
                            case DebuffSkill.DebuffType.AddDamage:
                                targetCharacter.addDamageRatio = m_playerSkillData.m_debuffSkill[i].m_ratio;
                                break;
                            case DebuffSkill.DebuffType.Attack:
                                targetCharacter.addDamageRatio = m_player.physicsDamageResistance * m_playerSkillData.m_debuffSkill[i].m_ratio;
                                break;
                        }
                    }
                }
            }
            if (m_playerSkillData.m_summonObject != null)
            {

            }
            if (m_playerSkillData.m_knockBack == true)
            {
                TimerData timerData = new TimerData(0 ,1);
                StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(targetCharacter, timerData, KnockBack));
                void KnockBack()
                {
                    targetCharacter.Knockback(m_mainGame.mainGame_StageDeta.GetMap());
                }
            }
            
        }
    }
}
