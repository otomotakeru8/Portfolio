using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    //作業時間（共通5秒）
    float m_PogressTime = 5;
    //計算用定数
    float m_ScaleY;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Destroy),m_PogressTime);
        m_ScaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTimeProgress = Time.deltaTime / (1 / m_ScaleY) / m_PogressTime;
        transform.localScale -= new Vector3(0, deltaTimeProgress, 0);
        transform.Translate(0, deltaTimeProgress, 0);
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
