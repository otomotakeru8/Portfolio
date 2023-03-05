using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerController : MonoBehaviour
{
    public float idospeed;
    //移動関連のパラメータ
    [Header("速さの最低値")]
    [SerializeField]
    private float minSpeed = 3.0f;
    [Header("速さの最高値")]
    [SerializeField]
    private float maxSpeed = 5.0f;
    [Header("プレイヤーの方向転換スピードの調整値")]
    //0.0fだと一切向きが変わらず1.0fだと入力後すぐ入力された方向へ向く
    [SerializeField, Range(0.0f, 1.0f)]
    private float turnRate = 0.8f;

    //移動速度
    private Vector3 velocity;

    //キャラクターコントローラー
    private CharacterController controller;

    //InspectorにてRangeの値が指定の範囲に収まるようにClamp処理
    private void OnValidate()
    {
        this.turnRate = Mathf.Clamp(this.turnRate, 0.0f, 1.0f);
    }

    //初期設定
    void Awake()
    {
        //キャラクターコントローラー取得
        this.controller = this.GetComponent<CharacterController>();

        //速度をゼロに設定
        this.velocity = Vector3.zero;

    }

    //更新処理
    void Update()
    {
        Vector3 vec = this.velocity;
        float Speed = 0.0f;

        //床に接地していたら歩く
        if (this.controller.isGrounded)
        {
            //ゲームパッドのスティック入力値を取得して移動ベクトルを作成
            //..ついでに接地しているのでY軸の値をリセット
            vec = new Vector3(Input.GetAxisRaw("L_Stick_V2"), 0, Input.GetAxisRaw("L_Stick_H2"));

            //入力値から得たベクトルの長さが0.1fを越えていれば速さを設定
            if (vec.magnitude > 0.1f)
            {
                //スティックの倒し具合によって速さを変更
                Speed = Mathf.Lerp(this.minSpeed, this.maxSpeed, vec.magnitude);

                //向きの変更
                Vector3 dir = vec.normalized;
                float rotate = Mathf.Acos(dir.z);
                if (dir.x < 0) rotate = -rotate;
                rotate *= Mathf.Rad2Deg;
                Quaternion Q = Quaternion.Euler(0, rotate, 0);
                //ここでモデルの向いている方向が徐々に変わるように処理しつつ
                //モデルの向きを変更
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Q, this.turnRate);
            }

            //移動ベクトルを正規化
            vec = vec.normalized;
        }

        //移動速度を設定
        this.velocity.x = vec.x * Speed;
        this.velocity.y = vec.y;
        this.velocity.z = vec.z * Speed;

        //重力による落下を設定
        this.velocity.y += Physics.gravity.y * Time.deltaTime;

        //移動させる
        this.controller.Move(this.velocity * Time.deltaTime);

        if (TitleScreen.ScreenState == 0)
        {
            // ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
            // メインメニューの入力はここです！
            // ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

            if (Input.GetKey("up"))
            {
                transform.position -= transform.right * idospeed * Time.deltaTime;
            }
            if (Input.GetKey("down"))
            {

                transform.position += transform.right * idospeed * Time.deltaTime;
            }
            if (Input.GetKey("right"))
            {

                transform.position += transform.forward * idospeed * Time.deltaTime;
            }
            if (Input.GetKey("left"))
            {
                transform.position -= transform.forward * idospeed * Time.deltaTime;
            }
        }
    }

}
