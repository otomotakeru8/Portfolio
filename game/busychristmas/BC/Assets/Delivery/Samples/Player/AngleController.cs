using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleController : MonoBehaviour
{
    /// <summary>
    /// 感度
    /// </summary>
    [SerializeField, Range(0.01F, 5.0F), Tooltip("感度")]
    private float sensitivity = 1.0F;

    /// <summary>
    /// 砲身のオブジェクト
    /// </summary>
    [SerializeField, Tooltip("砲身のオブジェクト")]
    private GameObject barrelObject = null;

    private float rightVertical = 0f;
    private float downLimit = -15f;
    private float upLimit = -45f;

    private float yRotate = 0f;

    void Start()
    {
        barrelObject.transform.rotation = Quaternion.Euler(downLimit, 90f, 0f);
    }

    void Update()
    {
        rightVertical = Input.GetAxis("RightVertical");

        if (rightVertical > 0f)
        {
            yRotate = Mathf.Clamp(yRotate + Time.deltaTime * 100 * sensitivity, upLimit, downLimit);
            barrelObject.transform.localEulerAngles = new Vector3(yRotate, 0, 0);
        }
        if (rightVertical < 0f)
        {
            yRotate = Mathf.Clamp(yRotate - Time.deltaTime * 100f * sensitivity, upLimit, downLimit);
            barrelObject.transform.localEulerAngles = new Vector3(yRotate, 0, 0);
        }
    }
}