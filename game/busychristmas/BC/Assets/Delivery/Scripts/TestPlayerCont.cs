using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerCont : MonoBehaviour
{
    [SerializeField,Tooltip("プレイヤー番号 0 or 1")] private int playerNum;//プレイヤー1かどうか
    [SerializeField,Tooltip("手の位置")]private GameObject HandPos;

    AllSoundsScript ss;
    private float h, v; //移動 X軸/Y軸
    private Vector3 diff;　//移動方向判定
    private Vector3 moveForward;
    private Transform myGift = null; //プレゼントを拾ったときにTransformを取得する
    private bool haveGift = false;　//プレゼントを所持　ON/OFF(初期 OFF)
    private GameObject GiftGenBlock = null; //プレゼントの生成を持つオブジェクト
    private GameObject PlayerHand = null;


    [SerializeField] private float moveSpeed = 8.0f;
    Rigidbody rb;
    private bool isStart = false;
    private bool isWall = false;

    void Start()
    {
        ss = GetComponent<AllSoundsScript>();
        rb = GetComponent<Rigidbody>();
        GiftGenBlock = GameObject.Find("GiftGenBlock");
        PlayerHand = GameObject.Find("HandPos");

        StartCoroutine("CanMove",3.0f);
    }

    void Update()
    {
        ThrowGiftCommand();                                //プレゼントを投げるメソッド
    }

    void FixedUpdate()
    {
        if (isStart)
        {
            if(playerNum == 0)
            {
                h = Input.GetAxis("Horizontal") * Time.deltaTime; //水平方向への移動
                v = Input.GetAxis("Vertical") * Time.deltaTime;    //垂直方向への移動
                                                                   // カメラの方向から、X-Z平面の単位ベクトルを取得
                Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1));
                Vector3 cameraRight = Vector3.Scale(Camera.main.transform.right, new Vector3(1, 0, 1));
                // 方向キーの入力値とカメラの向きから、移動方向を決定
                moveForward = moveSpeed * (cameraForward.normalized * v + cameraRight.normalized * h);
            }
            

            if (isWall == false)
            {
                // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
                rb.velocity = moveForward.normalized * moveSpeed + new Vector3(0, 0, 0);
            }
            if (isWall == true)
            {
                // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
                rb.velocity = (moveForward.normalized * moveSpeed + new Vector3(0, 0, 0)) * 0f;
            }

            // キャラクターの向きを進行方向に
            if (moveForward != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveForward);
            }
        }
    }

    public GameObject getHandPos()
    {
        return this.HandPos;
    }

    public int getPlayerNum()
    {
        return this.playerNum;
    }

    //プレゼントを拾った判定メソッド
    public void haveGiftFind()
    {
        PlayerHand.GetComponent<DrawArc>().ArcSwitch();
        haveGift = true;
        myGift = this.transform.Find("HandPos/Gift(Clone)");
    }

    //プレゼントを投げるメソッド
    private void ThrowGiftCommand()
    {
        if (haveGift == true)
        {
            myGift.position = PlayerHand.transform.position;
        }
        if(Input.GetKeyDown("joystick button 1") && haveGift == true || Input.GetKeyDown(KeyCode.Space) && haveGift == true)// B ボタン
        {

            //コライダーのトリガー切り替え
            StartCoroutine("GiftTriggerSwitch");
            

            //プレゼントを投げる
            PlayerHand.GetComponent<ShootBullet>().ThrowGift(myGift);
            ss.PopSE(0);

            //プレゼントを持っていない判定にする
            haveGift = false;

            //プレゼントのオブジェクトを親(Player)から切り離す 
            myGift.transform.parent = null;

            //プレゼントを投げ終わった判定
            GiftGenBlock.GetComponent<GiftGen>().throwGifted(playerNum);
            PlayerHand.GetComponent<DrawArc>().ArcSwitch();
        }
    }

    private IEnumerator CanMove(float time)
    {
        yield return new WaitForSeconds(time);
        isStart = true;
    }
    public IEnumerator GiftTriggerSwitch()
    {
        yield return new WaitForSeconds(0.03f);
        Collider cl = myGift.GetComponent<Collider>();
        cl.isTrigger = false;
    }

    public void ifHitWall(bool setBool)
    {
        isWall = setBool;
    }
}
