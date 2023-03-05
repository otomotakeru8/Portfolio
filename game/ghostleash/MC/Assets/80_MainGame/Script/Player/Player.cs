using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public partial class Player : MainGameCharacterModel
{
    public int m_myNumber;
    public PlayerSkill[] m_playerSkill = new PlayerSkill[3];

    public bool m_ult;
    SkillEvent m_ultSkillEvent;
    float m_grudgeAmount;
    float m_grudgeAmountIncreasePercentage = 1;
    int m_ultCost;
    int m_ultStack;
    int m_maxUltStack;

    SkillEvent m_passiveSkill;
    int m_passiveStack;
    int m_maxPassiveStack;

    SkillEvent m_relicSkill;

    public bool m_goback;
    public int m_relocationFrame;
    int m_relocationFrameValue;

    Damage m_damage;
    int m_attackFrequency;
    int m_attackCooldown;

    Artifact m_artifact1;
    Artifact m_artifact2;
    Artifact m_artifact3;

    MainGame m_mainGame;

    public Charactor m_charactor;
    CharacterManager m_characterManager;

    //待機座標
    Vector2 m_outPosition = new Vector2(-1,-1);
    CharacterState m_lastStateType;

    public void Initialized(MainGame mainGame, int number)
    {
        m_mainGame = mainGame;
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            m_playerSkill[i] = new PlayerSkill();
            m_playerSkill[i].m_mainGame = mainGame;
            m_playerSkill[i].m_player = this;
        }
        m_myNumber = number;
        Charactor m_charactor = new Charactor();
        if (number == 1)
        {
            m_charactor = (Charactor)Master.formationdeta.selectcharactor1;
            m_artifact1 = Master.formationdeta.charactor1Artifacts[0];
            m_artifact2 = Master.formationdeta.charactor1Artifacts[1];
            m_artifact3 = Master.formationdeta.charactor1Artifacts[2];
        }
        if (number == 2)
        {
            m_charactor = (Charactor)Master.formationdeta.selectcharactor2;
            m_artifact1 = Master.formationdeta.charactor2Artifacts[0];
            m_artifact2 = Master.formationdeta.charactor2Artifacts[1];
            m_artifact3 = Master.formationdeta.charactor2Artifacts[2];
        }
        charactername = m_charactor.name;
        m_characterManager = mainGame.GetComponent<CharacterManager>();
        m_lastStateType = charactorState;
        m_playerSkill[0].m_skillLevel = m_charactor.skill1level;
        m_playerSkill[1].m_skillLevel = m_charactor.skill2level;
        m_playerSkill[2].m_skillLevel = m_charactor.skill3level;
        PlayerSetting playerSetting = new PlayerSetting(charactername, m_charactor);
        attackRange = playerSetting.attackRange;
    }

    private void Start()
    {
        charactorState = CharacterState.Standby;
        charactorAnimState = CharacterAnimState.Wait;
        m_goback = true;
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            m_playerSkill[i].m_skillEnabled = true;
            m_playerSkill[i].m_lateSkillEnabled = true;
        }
        directionRight = false;
    }

    public void FastUpDate()
    {
        resultingAttackPower = baseAttackPower;

        //スキルクールタイム
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            m_playerSkill[i].SkillCoolTimeCounter();
        }

        //スキルボタン
        SkillButtonEnable();
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            if (m_playerSkill[i].m_skillActivating == true)
            {
                m_playerSkill[i].m_skillEvent();
                m_playerSkill[i].m_skillCoolTime = m_playerSkill[i].m_skillCoolDown;
                m_playerSkill[i].m_skillStack = 0;
                m_playerSkill[i].m_skillActivating = false;
            }
        }

        //怨嗟
        UltStackCounter();
        if (m_ult == true && m_ultStack > 0)
        {
            m_ultSkillEvent();
            m_ultStack = 0;
        }

        //接敵
        if (findEnemy == true)
        {
            charactorState = CharacterState.Fight;
        }
        else
        {
            charactorState = m_lastStateType;
        }

        //撤退
        switch (charactorState)
        {
            case CharacterState.Resting:
                m_relocationFrameValue++;
                if (m_relocationFrameValue >= m_relocationFrame)
                {
                    charactorState = CharacterState.Standby;
                }
                break;
        }
    }

    public void UpDate()
    {
        //スキル
        if (skillEvent != null)
        {
            skillEvent();
            ReMoveAllEvents();
        }
        //パッシブスキル
        if (m_passiveSkill != null)
        {
            m_passiveSkill();
        }
        //遺物
        if (m_relicSkill != null)
        {
            m_relicSkill();
        }
        switch (charactorState)
        {
            case CharacterState.Fight:
                m_attackCooldown--;
                if (m_attackCooldown / addAttackCooldownRatio <= 0)
                {
                    m_attackCooldown = m_attackFrequency;
                    foreach (MainGameCharacterModel target in targetEnemy)
                    {
                        target.TakeDamage(new Damage(DamageType.physicsDamage, resultingAttackPower));
                    }
                }
                break;
        }
    }

    public void LateUpDate()
    {
        if (alive == false)
        {
            charactorState = CharacterState.Recovery;
        }

        if (charactorState == CharacterState.Standby || charactorState == CharacterState.Resting)
        {
            m_goback = true;
            position = m_outPosition;
        }

        switch (charactorState)
        {
            case CharacterState.Wait:
                charactorAnimState = CharacterAnimState.Wait;
                m_lastStateType = charactorState;
                break;
            case CharacterState.Fight:
                charactorAnimState = CharacterAnimState.Fight;
                break;
        }

        addAttackCooldownRatio = 1;
        addMoveSpeedRatio = 1;
        addAttackPowerRatio = 1;

        m_characterManager.CharacterVisualization(position,true, m_myNumber);
        m_characterManager.CharacterAnimation(true, m_myNumber, charactorAnimState, charactername,takeDamage);
        m_characterManager.SetCharacterDirection(true, m_myNumber, directionRight);
        m_characterManager.SetCharacterHpSlider(m_myNumber, hp,maxHp,true);
    }

    public void Deploy(Vector2 targetPosition)
    {
        charactorState = CharacterState.Wait;
        m_lastStateType = CharacterState.Wait;
        m_goback = false;
        position = targetPosition;
        displaying = true;
    }
}
