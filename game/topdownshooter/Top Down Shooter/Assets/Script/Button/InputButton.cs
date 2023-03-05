using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputButton : MonoBehaviour
{
    [SerializeField]
    GameObject Shift;
    [SerializeField]
    GameObject W;
    [SerializeField]
    GameObject A;
    [SerializeField]
    GameObject S;
    [SerializeField]
    GameObject D;
    [SerializeField]
    GameObject MLB;
    [SerializeField]
    GameObject MRB;

    Button m_shiftButton;
    Button m_wButton;
    Button m_aButton;
    Button m_sButton;
    Button m_dButton;
    Button m_mlbButton;
    Button m_mrbButton;

    // Start is called before the first frame update
    void Start()
    {
        m_shiftButton = Shift.GetComponent<Button>();
        m_wButton = W.GetComponent<Button>();
        m_aButton = A.GetComponent<Button>();
        m_sButton = S.GetComponent<Button>();
        m_dButton = D.GetComponent<Button>();
        m_mlbButton = MLB.GetComponent<Button>();
        m_mrbButton = MRB.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ColorBlock colorBlock = m_shiftButton.colors;
            colorBlock.colorMultiplier = 5;
            m_shiftButton.colors = colorBlock;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ColorBlock colorBlock = m_wButton.colors;
            colorBlock.colorMultiplier = 5;
            m_wButton.colors = colorBlock;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ColorBlock colorBlock = m_aButton.colors;
            colorBlock.colorMultiplier = 5;
            m_aButton.colors = colorBlock;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ColorBlock colorBlock = m_sButton.colors;
            colorBlock.colorMultiplier = 5;
            m_sButton.colors = colorBlock;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ColorBlock colorBlock = m_dButton.colors;
            colorBlock.colorMultiplier = 5;
            m_dButton.colors = colorBlock;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ColorBlock colorBlock = m_mlbButton.colors;
            colorBlock.colorMultiplier = 5;
            m_mlbButton.colors = colorBlock;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ColorBlock colorBlock = m_mrbButton.colors;
            colorBlock.colorMultiplier = 5;
            m_mrbButton.colors = colorBlock;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            ColorBlock colorBlock = m_shiftButton.colors;
            colorBlock.colorMultiplier = 1;
            m_shiftButton.colors = colorBlock;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            ColorBlock colorBlock = m_wButton.colors;
            colorBlock.colorMultiplier = 1;
            m_wButton.colors = colorBlock;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            ColorBlock colorBlock = m_aButton.colors;
            colorBlock.colorMultiplier = 1;
            m_aButton.colors = colorBlock;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            ColorBlock colorBlock = m_sButton.colors;
            colorBlock.colorMultiplier = 1;
            m_sButton.colors = colorBlock;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            ColorBlock colorBlock = m_dButton.colors;
            colorBlock.colorMultiplier = 1;
            m_dButton.colors = colorBlock;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ColorBlock colorBlock = m_mlbButton.colors;
            colorBlock.colorMultiplier = 1;
            m_mlbButton.colors = colorBlock;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            ColorBlock colorBlock = m_mrbButton.colors;
            colorBlock.colorMultiplier = 1;
            m_mrbButton.colors = colorBlock;
        }
    }
}
