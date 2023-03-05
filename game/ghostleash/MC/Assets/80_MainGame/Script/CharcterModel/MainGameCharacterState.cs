public class MainGameCharacterState : MainGameCharacterDamageModel
{
    public MainGameCharacterState() : base()
    {
        ;
    }

    public enum CharacterState
    {
        //出撃可能
        Standby,
        //待機
        Wait,
        //動く
        Run,
        //スタン
        Stan,
        //戦闘
        Fight,
        //スキル使用
        DoSkill,
        //帰る
        RunAway,
        //撤退
        Recovery,
        //出撃準備中
        Resting,
        //死亡
        Dead,
    }

    public enum CharacterAnimState
    {
        //待機
        Wait,
        //戦闘
        Fight,
        //スタン
        Stan,
        //勝利
        Win,
        //敗北
        Lose,
        //歩く
        Walk,
        //走る
        Run,
        //死亡
        Die,
        //拾う
        PickUp
    }

    public CharacterState charactorState = new CharacterState();
    public CharacterAnimState charactorAnimState = new CharacterAnimState();
}
