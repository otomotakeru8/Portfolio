﻿using UnityEngine;

public static class Constant
{

    //ステージの変数に代入する定数
    public const string main_ep1_1 = "m11";
    public const string main_ep1_2 = "m12";
    public const string main_ep1_3 = "m13";
    public const string main_ep1_4 = "m14";
    public const string main_ep2_1 = "m21";
    public const string main_ep2_2 = "m22";
    public const string main_ep2_3 = "m23";
    public const string main_ep2_4 = "m24";
    public const string main_ep3_1 = "m31";
    public const string main_ep3_2 = "m32";
    public const string main_ep3_3 = "m33";
    public const string main_ep3_4 = "m34";
    public const string main_ep4_1 = "m41";
    public const string main_ep4_2 = "m42";
    public const string main_ep4_3 = "m43";
    public const string main_ep4_4 = "m44";
    public const string main_ep5_1 = "m51";
    public const string main_ep5_2 = "m52";
    public const string main_ep5_3 = "m53";
    public const string main_ep5_4 = "m54";

    //難易度
    public const string easy = "easy";
    public const string normal = "normal";
    public const string hard = "hard";

    //ダメージ属性
    //ダメージ属性
    public enum DamageType
    {
        physicsDamage,
        zyuGeki,
        zyuRyoku
    }

    //ゲームステート
    public enum GameState
    {
        BeforeStart,
        PreparationPhase,
        GameRun,
        Wait,
        End,
        Result
    }

    //敵の名前
    public const string Tuyogarisyounen = "Tuyogarisyounen";
    public const string Namaikinasyouzyo = "Namaikinasyouzyo";
    public const string Koisurugyaru = "Koisurugyaru";
    public const string Kowamoteyanki = "Kowamoteyanki";
    public const string Piennnaonnnanoko = "Piennnaonnnanoko";
    public const string Piekin = "Piekin";
    public enum EnemyName
    {
        TUYOGARISYOUNEN,
        NAMIKINASYOUZYO,
        KOISURUGYARU,
        KOWAMOTEYANKI,
        PIENNNAONNNANOKO,
        PIEKIN
    }

    //敵ステート
    public enum Enemystate
    {
        Wait,
        Run,
        Stan,
        Fight,
        RunAway,
        Dead
    }

    //プレイヤーキャラクターの名前
    public const string Daemon = "Daemon";
    public const string Poltergeist = "Poltergeist";
    public const string Gore = "Gore";
    public const string Zashiki_warashi = "Zashiki_warashi";
    public const string Ghost = "Ghost";

    //プレイヤーのステート
    public enum Playerstate
    {
        Wait,
        Fight,
        Recovery,
        Dead,
        Resting
    }

    public const string Huanokan = "Huaの冠";
    public const string Onnnennokan = "Onnnenの冠";
    public const string Rekisennokan = "Rekisenの冠";
    public const string Yujyounokan = "Yujyouの冠";
    public const string Akatukinokan = "Akatukiの冠";

    public const string Huanoudewa = "Huaの腕輪";
    public const string Onnnennoudewa = "Onnnenの腕輪";
    public const string Rekisennoudewa = "Rekisenの腕輪";
    public const string Yujyounoudewa = "Yujyouの腕輪";
    public const string Akatukinoudewa = "Akatukiの腕輪";

    public const string Huanoyubiwa = "Huaの指輪";
    public const string Onnnennoyubiwa = "Onnnenの指輪";
    public const string Rekisennoyubiwa = "Rekisenの指輪";
    public const string Yujyounoyubiwa = "Yujyouの指輪";
    public const string Akatukinoyubiwa = "Akatukiの指輪";
}
