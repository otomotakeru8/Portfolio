using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    // 砲身のオブジェクト
    [SerializeField, Tooltip("砲身のオブジェクト")]
    private GameObject barrelObject = null;

    /// <summary>
    ///初期位置
    /// </summary>
    private Vector3 instantiatePosition;
    /// <summary>
    /// 初期座標(読み取り専用)
    /// </summary>
    public Vector3 InstantiatePosition
    {
        get { return instantiatePosition; }
    }

    /// <summary>
    /// 投げる速さ
    /// </summary>
    [SerializeField, Range(1.0F, 100.0F), Tooltip("投げる速さ")]
    private float speed = 1.0F;

    /// <summary>
    /// 初速度
    /// </summary>
    private Vector3 shootVelocity;
    /// <summary>
    /// 初速度(読み取り専用)
    /// </summary>
    public Vector3 ShootVelocity
    {
        get { return shootVelocity; }
    }

    void Update()
    {
        // 初速度を更新
        shootVelocity = barrelObject.transform.forward * speed;

        // 生成座標を更新
        instantiatePosition = barrelObject.transform.position;
    }

    // 発射
    public void ThrowGift(Transform Gift)
    {
        Rigidbody rid = Gift.GetComponent<Rigidbody>();
        rid.useGravity = true;
        rid.AddForce(shootVelocity * rid.mass, ForceMode.Impulse);
    }
}
