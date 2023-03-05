using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public enum SelectObject
    {
        Null,
        GameUI,
        Ground,
        Tree,
        Rock,
        Tower,
    }

    Camera m_camera;
    static SelectObject m_select = 0;
    static GameObject m_hitObject;
    int m_priority;

    float m_dragDistance = 0;
    Vector2 m_lateMousePos;
    static bool m_onDrag;
    bool m_functionStop;

    private void Start()
    {
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_functionStop == true)
        {
            return;
        }
        OnClick();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            m_lateMousePos = Input.mousePosition;
            if (m_select == SelectObject.GameUI)
            {
                m_functionStop = true;
                return;
            }
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (m_lateMousePos == null)
            {
                m_lateMousePos = Input.mousePosition;
            }
            m_dragDistance += Vector2.Distance(m_lateMousePos, Input.mousePosition);
            m_lateMousePos = Input.mousePosition;
        }
        if (m_onDrag == false && m_dragDistance >= 10)
        {
            m_onDrag = true;
        }
    }

    private void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            /*
            if (m_dragDistance < 10)
            {
                OnClick();
            }
            */
            m_dragDistance = 0;
            m_onDrag = false;
            m_functionStop = false;
            m_select = SelectObject.Null;
        }
    }

    void OnClick()
    {
        Ray ray = m_camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] raycastHit = Physics.RaycastAll(ray, 60f);
        m_hitObject = null;
        m_select = SelectObject.Null;
        m_priority = 0;
        foreach (RaycastHit hit in raycastHit)
        {
            if (hit.collider.gameObject.CompareTag("GameUI") == true)
            {
                m_select = SelectObject.GameUI;
                m_hitObject = null;
                break;
            }
            if (m_priority > 3) continue;
            if (hit.collider.gameObject.name.Contains("Tower") == true || hit.collider.gameObject.CompareTag("Tower") == true)
            {
                m_select = SelectObject.Tower;
                m_hitObject = hit.collider.gameObject;
                m_priority = 3;
            }
            if (m_priority > 2) continue;
            if (hit.collider.gameObject.name.Contains("Tree") == true || hit.collider.gameObject.CompareTag("Tree") == true)
            {
                m_select = SelectObject.Tree;
                m_hitObject = hit.collider.gameObject;
                m_priority = 2;
            }
            if (m_priority > 1) continue;
            if (hit.collider.gameObject.name.Contains("Rock") == true || hit.collider.gameObject.CompareTag("Rock") == true)
            {
                m_select = SelectObject.Rock;
                m_hitObject = hit.collider.gameObject;
                m_priority = 1;
            }
            if (m_priority > 0) continue;
            if (hit.collider.gameObject.name.Contains("Ground") == true || hit.collider.gameObject.CompareTag("Ground") == true)
            {
                m_select = SelectObject.Ground;
                m_hitObject = hit.collider.gameObject;
            }
        }
    }

    /// <summary>
    /// マウス左クリックをタップ時のカーソル位置にあるオブジェクトを検索
    /// </summary>
    /// <param name="searchValue">SelectObjectのキー</param>
    /// <param name="gameObject">オブジェクトのout</param>
    /// <returns>bool(キーとオブジェクトが一致したかどうか)</returns>
    public static bool GetMouseLeftButton(SelectObject searchValue, out GameObject gameObject)
    {
        gameObject = null;
        if (m_select == searchValue)
        {
            gameObject = m_hitObject;
            return true;
        }
        return false;
    }

    public static bool GetMouseDrag()
    {
        return m_onDrag;
    }
}
