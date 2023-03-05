﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;
using UnityEngine.SceneManagement;

public partial class MainGame : MonoBehaviour
{
    //ゲームステート
    public GameState gamestate;
    GameState lateGameState;

    //マスターオブジェクト
    GameObject master;

    //ボタンマネージャー
    [HideInInspector]
    public ButtonManager buttonManager;

    //キャラクターマネージャー
    CharacterManager characterManager;

    //ステージ
    string stage;

    //ステージUI
    MainGame_StageUI mainGame_StageUI;

    //影
    ShadowMesh shadowMesh;

    //マテリアル
    [SerializeField]
    Material shadow;
    [SerializeField]
    Material voidmaterial;
    [SerializeField]
    Material deployable;
    [SerializeField]
    Material notAllowed;

    //パネル
    [SerializeField]
    GameObject PausePanel;
    [SerializeField]
    GameObject RetirePanel;

    //難易度
    string difficulty;

    //ステージデータ
    public MainGame_StageDeta mainGame_StageDeta;

    //現在のウェーブ
    int waveNumber;

    //キャラクターが配置された
    bool onStageCharacter;
    bool lateOnStageCharacter;

    //キャラクターを配置可能
    bool canDeploy;

    //ゲーム内時間軸
    public float gameSpeed { get; private set;}
    float timeLine;

    //勝敗
    bool playerWin;

    //**イベント**
    //一時停止
    public bool pause;
    //スロウモード
    bool slowMode;
    //キャラクター１を選択
    public bool character1UI;
    //キャラクター１スキル１
    public bool character1skil1;
    //キャラクター１スキル２
    public bool character1skil2;
    //キャラクター１スキル３
    public bool character1skil3;
    //キャラクター１撤退
    public bool character1goback;
    //キャラクター２を選択
    public bool character2UI;
    //キャラクター２スキル１
    public bool character2skil1;
    //キャラクター２スキル２
    public bool character2skil2;
    //キャラクター２スキル３
    public bool character2skil3;
    //キャラクター２撤退
    public bool character2goback;
    //行動中キャラクター１を選択
    public bool character1;
    //行動中キャラクター２を選択
    public bool character2;
    //キャラクター配置中
    bool beingCharacterDeploy;

    //敵
    [HideInInspector]
    public Enemy[] enemies;

    //プレイヤー
    [HideInInspector]
    public Player[] players;
    [HideInInspector]
    public Vector2 player1pos;
    [HideInInspector]
    public Vector2 player2pos;

    [SerializeField]
    PlayerSkillData[] m_daemonSkillDatas;
    [SerializeField]
    PlayerSkillData[] m_poltergeistSkillDatas;
    [SerializeField]
    PlayerSkillData[] m_goreSkillDatas;
    [SerializeField]
    PlayerSkillData[] m_zashiki_warashiSkillDatas;
    [SerializeField]
    PlayerSkillData[] m_ghostSkillDatas;

    //カーソルの位置
    StageGridUI stageGridUI;

    //初期化
    void Start()
    {
        gamestate = GameState.PreparationPhase;
        gameSpeed = 1;
        master = GameObject.Find("MasterObject");
        StageSelect_Deta.selectStageNumber = Constant.main_ep1_1;
        stage = StageSelect_Deta.selectStageNumber;
        character1goback = true;
        character2goback = true;
        canDeploy = false;

        difficulty = StageSelect_Deta.selectDifficulty;
        mainGame_StageDeta = new MainGame_StageDeta(stage);
        mainGame_StageUI = GetComponent<MainGame_StageUI>();
        mainGame_StageUI.SendMessage("SetBackGround", int.Parse(stage.Substring(1,2)));
        mainGame_StageUI.SendMessage("SetObstacle", int.Parse(stage.Substring(1, 2)));
        mainGame_StageUI.SendMessage("SetEnemyTargetObject");
        waveNumber = 1;
        playerWin = false;
        onStageCharacter = false;
        shadowMesh = GameObject.Find("ShadowObject").GetComponent<ShadowMesh>();
        shadowMesh.Initialize();
        buttonManager = GetComponent<ButtonManager>();
        buttonManager.Initialize();
        stageGridUI = GameObject.Find("UICamera").GetComponent<StageGridUI>();
        PausePanel.SetActive(false);
        RetirePanel.SetActive(false);
        characterManager = GetComponent<CharacterManager>();


        GeneratEnemy();
        GeneratPlayer();
        ButtonSetting();
        ChangeView();

    }

    // Update is called once per frame
    void Update()
    {
        switch (gamestate)
        {
            case GameState.BeforeStart:

                break;
            case GameState.PreparationPhase:
                GameInputCheck();
                SlowCheck();
                GameUpData();
                ChangeView();
                if (onStageCharacter == true && onStageCharacter != lateOnStageCharacter) Invoke(nameof(GameStateToGameRun), 10f);
                lateOnStageCharacter = onStageCharacter;
                break;
            case GameState.GameRun:
                GameInputCheck();
                SlowCheck();
                GameUpData();
                ChangeView();
                WaveClearCheck();
                break;
            case GameState.Wait:
                
                break;
            case GameState.End:
                //終了表示
                Debug.Log("終了");
                break;
            case GameState.Result:

                break;
        }
        timeLine = Time.deltaTime * gameSpeed;
    }

    //ウェーブを次へ
    void ChengeWave()
    {
        gamestate = GameState.PreparationPhase;
        waveNumber += 1;
        onStageCharacter = true;
        Invoke(nameof(EnemyReSpawn),2);
    }

    void EnemyReSpawn()
    {
        GeneratEnemy();
        characterManager.CharaReLoad();
    }

    void GameStateToGameRun()
    {
        gamestate = GameState.GameRun;
        foreach (Enemy enemy in enemies)
        {
            enemy.charactorState = MainGameCharacterState.CharacterState.Run;
        }
    }

    //ゲーム入力確認
    void GameInputCheck()
    {
        if (pause == true)
        {
            if (gamestate == GameState.PreparationPhase) lateGameState = GameState.PreparationPhase;
            if (gamestate == GameState.GameRun) lateGameState = GameState.GameRun;
            gamestate = GameState.Wait;
            PausePanel.SetActive(true);
        }
        if (character1UI == true)
        {
            slowMode = true;
            beingCharacterDeploy = true;
        }
        if (character1skil1 == true)
        {
            players[0].m_playerSkill[0].m_skillActivating = true;
        }
        if (character1skil2 == true)
        {
            players[0].m_playerSkill[1].m_skillActivating = true;
        }
        if (character1skil3 == true)
        {
            players[0].m_playerSkill[2].m_skillActivating = true;
        }
        if (character2UI == true)
        {
            slowMode = true;
            beingCharacterDeploy = true;
        }
        if (character2skil1 == true)
        {
            players[1].m_playerSkill[0].m_skillActivating = true;
        }
        if (character2skil2 == true)
        {
            players[1].m_playerSkill[1].m_skillActivating = true;
        }
        if (character2skil3 == true)
        {
            players[1].m_playerSkill[2].m_skillActivating = true;
        }
    }

    //ポーズ解除
    public void Unpause()
    {
        pause = false;
        gamestate = lateGameState;
        PausePanel.SetActive(false);
        buttonManager.AllButtonEnable();
    }

    //リタイヤ画面
    public void OnRetirePanel()
    {
        PausePanel.SetActive(false);
        RetirePanel.SetActive(true);
    }

    //リタイア拒否
    public void NoRetire()
    {
        PausePanel.SetActive(true);
        RetirePanel.SetActive(false);
    }

    //リタイア合意
    public void OnRetire()
    {
        Load_Deta.Nextscenename = "StageSelectScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }

    //スロウモード(判定と切り替えにかかわる処理)
    void SlowCheck()
    {
        if (slowMode == true) gameSpeed = 0.25f;
        else gameSpeed = 1f;

        if (beingCharacterDeploy == true)
        {
            CharacterDeployMode();
        }
    }

    //キャラクターを配置
    void CharacterDeployMode()
    {
        if (MasterInput.Touchended == true)
        {
            mainGame_StageDeta = new MainGame_StageDeta(stage);
            bool[,] canDeployGlid = new bool[10, 6];
            //障害物とキャラクターを避ける
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    canDeployGlid[i, j] = !mainGame_StageDeta.GetMap()[i, j];
                    Vector2[] targetPos = new Vector2[] { new Vector2(i, j) };
                    if (SearchCharacter(new Vector2(0,0), targetPos, true, true, true).Length > 0)
                    {
                        canDeployGlid[i, j] = false;
                    }
                }
            }

            if (stageGridUI.selectGrid != new Vector2Int(-1, -1))
            {
                //キャラクターを設置
                if (character1UI == true && canDeployGlid[stageGridUI.selectGrid.x, stageGridUI.selectGrid.y] == true)
                {
                    players[0].Deploy(stageGridUI.selectGrid);
                    buttonManager.ButtoEnableByName("Character1Skill1");
                    buttonManager.ButtoEnableByName("Character1Skill2");
                    buttonManager.ButtoEnableByName("Character1Skill3");
                    if (onStageCharacter == false) onStageCharacter = true;
                }
                else if (character1UI == true)
                {
                    buttonManager.ButtoEnableByName("Character1UI");
                }
                if (character2UI == true && canDeployGlid[stageGridUI.selectGrid.x, stageGridUI.selectGrid.y] == true)
                {
                    players[1].Deploy(stageGridUI.selectGrid);
                    buttonManager.ButtoEnableByName("Character2Skill1");
                    buttonManager.ButtoEnableByName("Character2Skill2");
                    buttonManager.ButtoEnableByName("Character2Skill3");
                    if (onStageCharacter == false) onStageCharacter = true;
                }
                else if (character2UI == true)
                {
                    buttonManager.ButtoEnableByName("Character2UI");
                }
            }
            else 
            {
                if (character1UI == true)
                {
                    buttonManager.ButtoEnableByName("Character1UI");

                }
                else
                {
                    buttonManager.ButtoEnableByName("Character2UI");

                }
            }

            character1UI = false;
            character2UI = false;
            buttonManager.AllButtonEnable();
            beingCharacterDeploy = false;
            slowMode = false;
        }
    }

    //ウェーブが終わったか判定
    void WaveClearCheck()
    {
        int enemyValue = enemies.Length;
        int value = 0;
        foreach (Enemy e in enemies)
        {
            if (e.alive == false)
            {
                value++;
            } 
            if (value == enemyValue)
            {
                ChengeWave();
            }
        }
    }

    //ゲーム内アップデート
    void GameUpData()
    {
        foreach(Player player in players)
        {
            player.findEnemy = false;
            MainGameCharacterModel[] target = SearchCharacter(player.position,player.attackRange,false,true,false);
            if (target.Length > 0)
            {
                player.targetEnemy = target;
                player.findEnemy = true;
            }
        }
        foreach(Enemy enemy in enemies)
        {
            enemy.findEnemy = false;
            MainGameCharacterModel[] target = SearchCharacter(enemy.position,enemy.attackRange, true, false, false);
            if (target.Length > 0)
            {
                enemy.targetEnemy = target;
                enemy.findEnemy = true;
            }
        }
        //fast
        foreach(Player player in players)
        {
            player.FastUpDate();
        }
        foreach(Enemy enemy in enemies)
        {
            enemy.FastUpDate();
        }
        //nomal
        foreach (Player player in players)
        {
            player.UpDate();
        }
        foreach (Enemy enemy in enemies)
        {
            enemy.UpDate();
        }
        //late
        foreach (Player player in players)
        {
            player.LateUpDate();
        }
        foreach (Enemy enemy in enemies)
        {
            enemy.LateUpDate();
        }
    }

    //セーブデータの情報からプレイヤーキャラクターを生成
    void GeneratPlayer()
    {
        if (Master.formationdeta.GetCharactor1() != null)
        {
            if (Master.formationdeta.GetCharactor2() != null)
            {
                players = new Player[] { gameObject.AddComponent<Player>(), gameObject.AddComponent<Player>() };
                players[0].Initialized(this,1);
                players[1].Initialized(this,2);
            }
            else
            {
                players = new Player[] { gameObject.AddComponent<Player>() };
                players[0].Initialized(this, 1);
            }
        }
        else
        {
            if (Master.formationdeta.GetCharactor2() != null)
            {
                players = new Player[] { gameObject.AddComponent<Player>() };
                players[0].Initialized(this, 2);
            }
            else
            {
                //ありえない
            }
        }

        for (int i = 0; i < players.Length; i++)
        {
            switch (players[i].name)
            {
                case Daemon:
                    for (int j = 0; j < 3; j++)
                    {
                        players[i].m_playerSkill[j].m_playerSkillData = m_daemonSkillDatas[j];
                    }
                    break;
                case Poltergeist:
                    for (int j = 0; j < 3; j++)
                    {
                        players[i].m_playerSkill[j].m_playerSkillData = m_poltergeistSkillDatas[j];
                    }
                    break;
                case Gore:
                    for (int j = 0; j < 3; j++)
                    {
                        players[i].m_playerSkill[j].m_playerSkillData = m_goreSkillDatas[j];
                    }
                    break;
                case Zashiki_warashi:
                    for (int j = 0; j < 3; j++)
                    {
                        players[i].m_playerSkill[j].m_playerSkillData = m_zashiki_warashiSkillDatas[j];
                    }
                    break;
                case Ghost:
                    for (int j = 0; j < 3; j++)
                    {
                        players[i].m_playerSkill[j].m_playerSkillData = m_ghostSkillDatas[j];
                    }
                    break;
            }
        }
    }

    //ボタン初期設定
    void ButtonSetting()
    {
        bool player1 = false;
        bool player2 = false;
        foreach (Player player in players)
        {
            if (player.m_myNumber == 1)
            {
                player1 = true;
            }
            if (player.m_myNumber == 2)
            {
                player2 = true;
            }
        }
        buttonManager.ButtonDisableByName("Character1Skill1");
        buttonManager.ButtonDisableByName("Character1Skill2");
        buttonManager.ButtonDisableByName("Character1Skill3");
        buttonManager.ButtonDisableByName("Character2Skill1");
        buttonManager.ButtonDisableByName("Character2Skill2");
        buttonManager.ButtonDisableByName("Character2Skill3");
        if (player1 == false)
        {
            buttonManager.ButtonDisableByName("Character1UI");
        }
        if (player2 == false)
        {
            buttonManager.ButtonDisableByName("Character2UI");
        }
    }

    //Viewの変更
    void ChangeView()
    {
        //影のリセット
        bool[,] defaultShadow = new bool[10,6];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                defaultShadow[i,j] = true;
            }
        }

        shadowMesh.SetColor(defaultShadow, shadow);

        //障害物を避けて影を生成
        mainGame_StageDeta.view.viewArray = mainGame_StageDeta.GetMap();

        //キャラクターの視界を確保
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].GetName() == "" || players[i].charactorState == MainGameCharacterState.CharacterState.Standby || players[i].charactorState == MainGameCharacterState.CharacterState.Resting || players[i].charactorState == MainGameCharacterState.CharacterState.Dead)
            {
                continue;
            }
            if (players[i].directionRight == true)
            {
                for (int j = 0; j < players[i].viewRange.Length; j++)
                {
                    if ((int) (players[i].position.x + players[i].viewRange[j].x) > 9 || (int)(players[i].position.y + players[i].viewRange[j].y) > 5 || (int)(players[i].position.x + players[i].viewRange[j].x) < 0 || (int)(players[i].position.y + players[i].viewRange[j].y) < 0)
                    {
                        continue;
                    }
                    mainGame_StageDeta.view.viewArray[(int)(players[i].position.x + players[i].viewRange[j].x), (int)(players[i].position.y + players[i].viewRange[j].y)] = true;
                }
            }
            else
            {
                for (int j = 0; j < players[i].viewRange.Length; j++)
                {
                    if ((int)(players[i].position.x + players[i].viewRange[j].x * -1) > 9 || (int)(players[i].position.y + players[i].viewRange[j].y) > 5 || (int)(players[i].position.x + players[i].viewRange[j].x * -1) < 0 || (int)(players[i].position.y + players[i].viewRange[j].y) < 0)
                    {
                        continue;
                    }
                    mainGame_StageDeta.view.viewArray[(int)(players[i].position.x + (players[i].viewRange[j].x * -1)), (int)(players[i].position.y + players[i].viewRange[j].y)] = true;
                }
            }
        }

        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] == null || enemies[i].GetName() == "")
            {
                continue;
            }
            if (enemies[i].directionRight == true)
            {
                for (int j = 0; j < enemies[i].viewRange.Length; j++)
                {
                    if ((int)(enemies[i].position.x + enemies[i].viewRange[j].x) > 9 || (int)(enemies[i].position.y + enemies[i].viewRange[j].y) > 5 || (int)(enemies[i].position.x + enemies[i].viewRange[j].x) < 0 || (int)(enemies[i].position.y + enemies[i].viewRange[j].y) < 0)
                    {
                        continue;
                    }
                    mainGame_StageDeta.view.viewArray[(int)(enemies[i].position.x + enemies[i].viewRange[j].x), (int)(enemies[i].position.y + enemies[i].viewRange[j].y)] = true;
                }
            }
            else
            {
                for (int j = 0; j < enemies[i].viewRange.Length; j++)
                {
                    if ((int)(enemies[i].position.x + enemies[i].viewRange[j].x * -1) > 9 || (int)(enemies[i].position.y + enemies[i].viewRange[j].y) > 5 || (int)(enemies[i].position.x + enemies[i].viewRange[j].x * -1) < 0 || (int)(enemies[i].position.y + enemies[i].viewRange[j].y) < 0)
                    {
                        continue;
                    }
                    mainGame_StageDeta.view.viewArray[(int)(enemies[i].position.x + (enemies[i].viewRange[j].x * -1)), (int)(enemies[i].position.y + enemies[i].viewRange[j].y)] = true;
                }
            }
        }

        //出現場所と目標を見えるように
        mainGame_StageDeta.view.viewArray[(int)mainGame_StageDeta.enemy1_spawn_position.x, (int)mainGame_StageDeta.enemy1_spawn_position.y] = true;
        mainGame_StageDeta.view.viewArray[(int)mainGame_StageDeta.enemy2_spawn_position.x, (int)mainGame_StageDeta.enemy2_spawn_position.y] = true;
        mainGame_StageDeta.view.viewArray[(int)mainGame_StageDeta.enemy1_target_object.x, (int)mainGame_StageDeta.enemy1_target_object.y] = true;
        mainGame_StageDeta.view.viewArray[(int)mainGame_StageDeta.enemy2_target_object.x, (int)mainGame_StageDeta.enemy2_target_object.y] = true;

        //表示
        shadowMesh.SetColor(mainGame_StageDeta.view.viewArray,voidmaterial);

        //キャラクター配置モード
        if (beingCharacterDeploy == true)
        {
            mainGame_StageDeta = new MainGame_StageDeta(stage);
            bool[,] canDeployGlid = new bool[10, 6];
            //障害物とキャラクターを避ける
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    canDeployGlid[i,j] = !mainGame_StageDeta.GetMap()[i,j];
                    Vector2[] targetPos = new Vector2[] { new Vector2(i, j) };
                    if (SearchCharacter(new Vector2(0,0), targetPos, true, true, true).Length > 0)
                    {
                        canDeployGlid[i, j] = false;
                    }
                }
            }
            canDeployGlid[(int)mainGame_StageDeta.enemy1_target_object.x, (int)mainGame_StageDeta.enemy1_target_object.y] = false;
            canDeployGlid[(int)mainGame_StageDeta.enemy2_target_object.x, (int)mainGame_StageDeta.enemy2_target_object.y] = false;
            //表示
            shadowMesh.SetColor(canDeployGlid, deployable);
        }
    }

    //メインゲーム終了
    void Exit()
    {
        Load_Deta.Nextscenename = "StageSelectScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }

    public void EnemyGoal()
    {
        playerWin = false;
        gamestate = GameState.End;
    }
}
