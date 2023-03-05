using UnityEngine;

public delegate void SkillEvent();

public class MainGameCharacterModel : MainGameCharacterState
{
    public string charactername = "";
    public bool displaying;

    public Vector2 position;
    protected Vector2[] targetPosition;
    int moveTargetPointer;
    Vector2 moveDirection;
    protected float moveSpeed;
    public float addMoveSpeedRatio;
    float movedValue;
    protected Vector2 targetObject;
    public bool directionRight;
    bool next;
    public Vector2[] viewRange;
    protected bool goal;

    public bool findEnemy;
    public MainGameCharacterModel[] targetEnemy;
    public Vector2[] attackRange;
    public float addAttackCooldownRatio;
    public int baseAttackPower;
    public float addAttackPowerRatio;
    protected int resultingAttackPower;
    protected SkillEvent skillEvent;

    public MainGameCharacterModel() : base()
    {
        moveTargetPointer = 1;
    }

    //名前取得
    public string GetName()
    {
        return charactername;
    }

    //移動
    protected void Move(float timeLine)
    {
        if (next == true || moveDirection == null)
        {
            moveDirection = targetPosition[moveTargetPointer] - position;
            next = false;
        }
        if (next == false)
        {
            float moveValue = (timeLine * moveSpeed * 0.016666f);
            position += moveDirection * moveValue;
            movedValue += moveValue;
            if (movedValue > 1f)
            {
                movedValue = 0;
                position = targetPosition[moveTargetPointer];
                if (position == targetObject)
                {
                    charactorState = CharacterState.RunAway;
                    directionRight = false;
                }
                moveTargetPointer++;
                if (targetPosition.Length <= moveTargetPointer)
                {
                    goal = true;
                    moveTargetPointer--;
                }
                next = true;
            }
        }
    }

    //ノックバック
    public void Knockback(bool[,] map)
    {
        if (map[(int)(targetPosition[moveTargetPointer - 1] + (-moveDirection)).x, (int)(targetPosition[moveTargetPointer - 1] + (-moveDirection)).y] == true)
        {
            position += (-moveDirection);
            moveTargetPointer--;
            targetPosition[moveTargetPointer] = targetPosition[moveTargetPointer + 1] + (-moveDirection);
        }
        else
        {
            position = targetPosition[moveTargetPointer - 1];
            next = false;
        }
    }

    public void AddSkillEvent(SkillEvent skillEvent)
    {
        this.skillEvent += skillEvent;
    }

    protected void ReMoveAllEvents()
    {
        foreach (var d in skillEvent.GetInvocationList())
        {
            skillEvent -= (SkillEvent)d;
        }
    }
}
