using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScaleManager : MonoBehaviour
{
    [SerializeField] TowerData m_towerData;
    Camera m_camera;
    RectTransform m_rectTransform;
    Canvas m_canvas;
    RectTransform m_canvasRect;
    Vector2 m_pos;
    Vector3 m_offSet = new Vector3(0,1.5f,0);
    Transform m_towerTransform;

    // Start is called before the first frame update
    void Start()
    {
        m_camera = Camera.main;
        m_rectTransform = GetComponent<RectTransform>();
        m_canvas = GetComponent<Graphic>().canvas;
        m_canvasRect = m_canvas.GetComponent<RectTransform>();
        m_towerTransform = GameObject.Find("Tower").GetComponent<TowerManager>().m_selectTower.transform;
        TransformChange();
    }

    // Update is called once per frame
    void Update()
    {
        TransformChange();
    }

    void TransformChange()
    {
        var screenPos = RectTransformUtility.WorldToScreenPoint(m_camera, m_towerTransform.position + m_offSet);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(m_canvasRect, screenPos, m_camera, out m_pos);
        m_rectTransform.localPosition = m_pos;
    }
}
