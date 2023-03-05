using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//タイミング300
public class Player : MonoBehaviour
{
    enum PlayerStatus
    {
        Wait,
        Move,
        Jump,
        HoldWait,
        HoldMove,
        HoldJump,
        Deth,
    }
    [SerializeField] PlayerStatus m_playerStatus = PlayerStatus.Wait;
    [SerializeField] float m_moveSpeed;
    [SerializeField] float m_jumpForce;
    [SerializeField] float m_jumpKeepForce;
    [SerializeField] bool m_playerRight;
    [SerializeField] bool m_canMove;
    bool m_hold;
    int m_stageNumber;
    Rigidbody m_rb;
    float m_lStickHorizontal;
    bool m_isGround;
    float m_moveDirection;
    bool m_jump;
    bool m_lateJump;
    int m_jumpTimeLine;
    float m_borderLineX;
    [SerializeField] int m_firstJumpProcessRange;
    [SerializeField] int m_secondJumpRrocessRange;
    bool m_deth;
    bool m_lateIsGround;
    bool m_landing;
    bool m_waitAnimation;
    bool m_respawnStack;

    // Start is called before the first frame update
    void Start()
    {
        m_jumpTimeLine = 0;
        m_rb = GetComponent<Rigidbody>();
        m_hold = false;
        m_playerRight = true;
        m_canMove = false;
        m_jump = false;
        m_lateJump = false;
        PassInitializ();
        GetPass();
        SetPass();
        m_deth = false;
        StageSteUp();
        m_waitAnimation = false;
    }

    void StageSteUp()
    {
        if (m_stageNumber == 1)
        {
            m_firstJumpProcessRange = 20;
            m_secondJumpRrocessRange = 30;
        }
        if (m_stageNumber == 3)
        {
            transform.localScale = new Vector3(0.075f, 0.075f, 1);
            m_jumpForce = 2;
            m_jumpKeepForce = 1;
            m_firstJumpProcessRange = 30;
            m_secondJumpRrocessRange = 30;
        }
    }

    // Update is called once per frame
    void Update()
    {
        InputDirector();
        ActionDirector();
        PlayerStatusDirector();
        if (m_waitAnimation == false)
        {
            PlayerAnimationDirector();
        }
        Border();
        GetPass();
        SetPass();
        Sound();
    }

    void Border()
    {
        if (Mathf.Abs(this.transform.position.x) > 8.5f) transform.position = new Vector3(m_borderLineX, transform.position.y);
        m_borderLineX = this.transform.position.x;
    }

    void PassInitializ()
    {
        Pass.PlayerPosition = transform.position;
        Pass.PlayerHold = m_hold;
        Pass.PlayerRight = m_playerRight;
        Pass.PlayerCanMove = m_canMove;
    }

    void GetPass()
    {
        m_canMove = Pass.PlayerCanMove;
        m_hold = Pass.PlayerHold;
        m_respawnStack = Pass.RespawnStack;
        m_stageNumber = Pass.StageNumber;
    }

    void SetPass()
    {
        Pass.PlayerRight = m_playerRight;
        Pass.PlayerPosition = transform.position;
        Pass.PlayerHold = m_hold;
    }

    void InputDirector()
    {
        if (m_canMove == true)
        {
            m_lStickHorizontal = Input.GetAxis("L_Stick_H");
            if (Input.GetKey(KeyCode.A)) m_lStickHorizontal = -0.5f;
            if (Input.GetKey(KeyCode.D)) m_lStickHorizontal = 0.5f;
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) m_lStickHorizontal = 0;
            if (m_lStickHorizontal < 0) m_moveDirection = -1;
            if (m_lStickHorizontal > 0) m_moveDirection = 1;
            if (m_lStickHorizontal == 0) m_moveDirection = 0;
            if (m_isGround == true)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0")) m_jump = true;
            }
            if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown("joystick button 2")) DethDirector();
        }
    }

    void ActionDirector()
    {
        m_rb.velocity = new Vector3(m_moveDirection * m_moveSpeed, m_rb.velocity.y, 0);
        if (m_jump) JumpDirector();
        if (m_canMove == false)
        {
            m_lStickHorizontal = 0;
            m_moveDirection = 0;
        }
    }

    void Sound()
    {
        if ((m_lateJump != m_jump) && m_jump == true) NewSoundScriot.Jump1 = true;
        m_lateJump = m_jump;
        if (m_playerStatus == PlayerStatus.Move) NewSoundScriot.Run1 = true;
        else NewSoundScriot.Run1 = false;
    }

    void JumpDirector()
    {
        if (m_jumpTimeLine <= m_secondJumpRrocessRange) m_jumpTimeLine++;
        if (m_jumpTimeLine <= m_firstJumpProcessRange)
        {
            m_rb.velocity = new Vector3(m_rb.velocity.x, m_jumpForce);
            if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp("joystick button 0")) m_jumpTimeLine = m_firstJumpProcessRange;
            m_isGround = false;
        }
        if (m_jumpTimeLine > m_firstJumpProcessRange && m_jumpTimeLine <= m_secondJumpRrocessRange) m_rb.AddForce(0, m_jumpKeepForce, 0);
    }

    private void OnCollisionStay(Collision collision)
    {
        if ((collision.gameObject.tag == "Flor") || (collision.gameObject.tag == "iwa"))
        {
            m_isGround = true;
            if (m_jumpTimeLine > m_firstJumpProcessRange)
            {
                m_jumpTimeLine = m_secondJumpRrocessRange;
                m_jump = false;
                m_jumpTimeLine = 0;
            }
        }
        if ((m_respawnStack == false) && (collision.gameObject.tag == ("yuka")))
        {
            FindObjectOfType<PlayerDirector>().StartRespawn();
            DethDirector();
        }

    }

    void PlayerStatusDirector()
    {
        if (m_hold == false)
        {
            if (m_moveDirection == 0) m_playerStatus = PlayerStatus.Wait;
            if (m_moveDirection != 0) m_playerStatus = PlayerStatus.Move;
            if (m_lateJump == true) m_playerStatus = PlayerStatus.Jump;
        }
        if (m_hold == true)
        {
            if (m_moveDirection == 0) m_playerStatus = PlayerStatus.HoldWait;
            if (m_moveDirection != 0) m_playerStatus = PlayerStatus.HoldMove;
            if (m_lateJump == true) m_playerStatus = PlayerStatus.HoldJump;
        }
        if (m_deth == true) m_playerStatus = PlayerStatus.Deth;
        if (m_moveDirection > 0) m_playerRight = true;
        if (m_moveDirection < 0) m_playerRight = false;
    }

    void PlayerAnimationDirector()
    {
        Animator animator = GetComponent<Animator>();
        int Animaint = animator.GetInteger("panime");
        if (m_lateIsGround != m_isGround && m_isGround == true)
        {
            m_landing = true;
            NewSoundScriot.Landing1 = true;
        }
        if (m_playerRight == true)
        {
            if (m_playerStatus == PlayerStatus.Wait) Animaint = 0;
            if (m_playerStatus == PlayerStatus.Move) Animaint = 2;
            if (m_playerStatus == PlayerStatus.Jump)
            {
                if (m_rb.velocity.y > 0) Animaint = 5;
                if (m_rb.velocity.y < 0) Animaint = 6;
                if (m_jumpTimeLine <= m_firstJumpProcessRange) Animaint = 4;
                if (m_landing == true)
                {
                    Animaint = 7; 
                    m_waitAnimation = true;
                    Invoke(nameof(AnimationWait), 0.25f);
                }
            }
            if (m_playerStatus == PlayerStatus.HoldWait) Animaint = 12;
            if (m_playerStatus == PlayerStatus.HoldMove) Animaint = 14;
            if (m_playerStatus == PlayerStatus.HoldJump)
            {
                if (m_rb.velocity.y > 0) Animaint = 17;
                if (m_rb.velocity.y < 0) Animaint = 18;
                if (m_jumpTimeLine <= m_firstJumpProcessRange) Animaint = 16;
                if (m_landing == true)
                {
                    Animaint = 19;
                    m_waitAnimation = true;
                    Invoke(nameof(AnimationWait), 0.25f);
                }
            }
            if (m_playerStatus == PlayerStatus.Deth) Animaint = 24;
        }
        if (m_playerRight == false)
        {
            if (m_playerStatus == PlayerStatus.Wait) Animaint = 1;
            if (m_playerStatus == PlayerStatus.Move) Animaint = 3;
            if (m_playerStatus == PlayerStatus.Jump)
            {
                if (m_rb.velocity.y > 0) Animaint = 9;
                if (m_rb.velocity.y < 0) Animaint = 10;
                if (m_jumpTimeLine <= m_firstJumpProcessRange) Animaint = 8;
                if (m_landing == true)
                {
                    Animaint = 11;
                    m_waitAnimation = true;
                    Invoke(nameof(AnimationWait), 0.25f);
                }
            }
            if (m_playerStatus == PlayerStatus.HoldWait) Animaint = 13;
            if (m_playerStatus == PlayerStatus.HoldMove) Animaint = 15;
            if (m_playerStatus == PlayerStatus.HoldJump)
            {
                if (m_rb.velocity.y > 0) Animaint = 21;
                if (m_rb.velocity.y < 0) Animaint = 22;
                if (m_jumpTimeLine <= m_firstJumpProcessRange) Animaint = 20;
                if (m_landing == true)
                {
                    Animaint = 23;
                    m_waitAnimation = true;
                    Invoke(nameof(AnimationWait), 0.25f);
                }
            }
            if (m_playerStatus == PlayerStatus.Deth) Animaint = 25;
        }
        if (m_lateIsGround == m_isGround) m_landing = false;
        m_lateIsGround = m_isGround;
        animator.SetInteger("panime", Animaint);
    }

    public void AnimationWait()
    {
        m_waitAnimation = false;
    }

    void DethDirector()
    {
        m_deth = true;
        Invoke(nameof(PlayerDeth), 1f);
        m_canMove = false;
    }

    void PlayerDeth()
    {
        Destroy(this.gameObject);
    }
}
