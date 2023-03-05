using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static Constant;

public partial class Enemy : MainGameCharacterModel
{
    //自分の番号
    public int m_myNumber;

    //戦闘時間
    const int m_maxFightTime = 600;
    int m_fightTime;

    //戦闘無視時間
    bool m_fightThrough;
    int m_maxThroughTime;
    int m_throughTime = 0;

    //通常攻撃
    Damage m_damage;
    int m_attackFrequency;
    int m_attackCooldown = 0;
    float m_attackAnimationFrequency = 0.3f;

    //MainGameのアドレス
    MainGame m_mainGame;

    //最後の移動状態
    CharacterState m_lastRunType;

    //表示クラス
    CharacterManager m_characterManager;

    //アニメーション用ディレイ
    bool m_animationSkip = false;

    public void Initialized(MainGame mainGame, string difficulty, string name, int number)
    {
        m_myNumber = number;
        m_mainGame = mainGame;
        if (m_myNumber == 1)
        {
            position = mainGame.mainGame_StageDeta.enemy1_spawn_position;
        }
        else
        {
            position = mainGame.mainGame_StageDeta.enemy2_spawn_position;
        }
        this.charactername = name;
        EnemySetting enemySetting = new EnemySetting(charactername, difficulty);
        maxHp = enemySetting.maxHp;
        hp = enemySetting.maxHp;
        baseAttackPower = enemySetting.attackDamage;
        attackRange = enemySetting.attackRange;
        viewRange = attackRange;
        moveSpeed = enemySetting.speed;
        physicsDamageResistance = enemySetting.physicsDamageResistance;
        zyuGekiResistance = enemySetting.zyuGekiResistance;
        zyuRyokuResistance = enemySetting.zyuRyokuResistance;
        directionRight = true;
        m_characterManager = mainGame.GetComponent<CharacterManager>();
        m_maxThroughTime = (int)(moveSpeed * 200f);
        m_damage = new Damage(DamageType.physicsDamage, baseAttackPower);
        m_damage.type = DamageType.physicsDamage;
        m_damage.value = baseAttackPower;
        displaying = true;
    }

    private void Start()
    {
        charactorState = CharacterState.Standby;
        charactorAnimState = CharacterAnimState.Wait;
        m_fightThrough = false;
    }

    //情報収集
    public void FastUpDate()
    {
        switch (charactorState)
        {
            case CharacterState.RunAway:
            case CharacterState.Run:
                if (findEnemy == true && m_fightThrough == false)
                {
                    charactorState = CharacterState.Fight;
                }
                break;
            case CharacterState.Fight:
                if (m_fightThrough == true)
                {
                    charactorState = m_lastRunType;
                }
                break;
        }
    }

    //計算
    public void UpDate()
    {
        //スキルの反映とリセット
        if (skillEvent != null)
        {
            skillEvent();
            ReMoveAllEvents();
        }
        switch (charactorState)
        {
            case CharacterState.Run:

                m_lastRunType = CharacterState.Run;
                Move(m_mainGame.gameSpeed);
                break;
            case CharacterState.RunAway:

                m_lastRunType = CharacterState.RunAway;
                Move(m_mainGame.gameSpeed);
                break;
            case CharacterState.Fight:
                m_attackCooldown--;
                if (m_attackCooldown <= 0)
                {
                    m_attackCooldown = m_attackFrequency;
                    foreach (MainGameCharacterModel target in targetEnemy)
                    {
                        m_damage.value = (int)(m_damage.value * addAttackPowerRatio);
                        target.TakeDamage(m_damage);
                    }
                }
                m_fightTime++;
                if (m_fightTime >= m_maxFightTime)
                {
                    m_fightThrough = true;
                }
                break;
        }
    }

    //結果
    public void LateUpDate()
    {
        if (alive == false)
        {
            charactorState = CharacterState.Dead;
            charactorAnimState = CharacterAnimState.Die;
        }
        if (m_animationSkip == false)
        {
            switch (charactorState)
            {
                case CharacterState.Wait:
                    charactorAnimState = CharacterAnimState.Wait;
                    break;
                case CharacterState.Run:
                case CharacterState.RunAway:
                    charactorAnimState = CharacterAnimState.Run;
                    break;
                case CharacterState.Fight:
                    charactorAnimState = CharacterAnimState.Fight;
                    m_animationSkip = true;
                    Invoke(nameof(EndAnimationSkip), m_attackAnimationFrequency);
                    break;
                case CharacterState.Stan:
                    charactorAnimState = CharacterAnimState.Stan;
                    m_animationSkip = true;
                    Invoke(nameof(EndAnimationSkip), m_attackAnimationFrequency);
                    break;
            }
        }

        if (goal == true)
        {
            m_mainGame.EnemyGoal();
            charactorAnimState = CharacterAnimState.Win;
        }

        m_damage.value = baseAttackPower;

        m_characterManager.CharacterVisualization(position, false, m_myNumber);
        m_characterManager.CharacterAnimation(false, m_myNumber, charactorAnimState,charactername,takeDamage);
        m_characterManager.SetCharacterDirection(false, m_myNumber, directionRight);
        m_characterManager.SetCharacterHpSlider(m_myNumber, hp, maxHp, false);
    }

    void EndAnimationSkip()
    {
        m_animationSkip = false;
    }
}
