using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpUI : MonoBehaviour
{

    float m_cameraDistance;
    Camera m_camera;
    RectTransform m_rectTransform;
    Canvas m_canvas;
    RectTransform m_canvasRect;
    Vector2 m_pos;
    Vector3 m_offSet = new Vector3(0, 1.5f, 0);
    public Transform m_enemyTransform;

    // Start is called before the first frame update
    void Start()
    {
        m_camera = Camera.main;
        m_rectTransform = GetComponent<RectTransform>();
        m_canvas = GetComponent<Graphic>().canvas;
        m_canvasRect = m_canvas.GetComponent<RectTransform>();
        TransformChange();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_enemyTransform == null)
        {
            m_enemyTransform = transform.parent.transform;
        }
        if (m_canvasRect == null)
        {
            GetComponent<Graphic>().canvas.GetComponent<RectTransform>();
        }
        TransformChange();
    }

    void TransformChange()
    {
        var screenPos = RectTransformUtility.WorldToScreenPoint(m_camera, m_enemyTransform.position + m_offSet);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(m_canvasRect, screenPos, m_camera, out m_pos);
        m_rectTransform.localPosition = m_pos;
    }

}
