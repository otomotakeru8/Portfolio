using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utilities;

public class TowerManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_tower;
    [SerializeField]
    GameObject m_talentTutorial;

    public GameObject m_selectTower;
    public GameObject m_lateSelectTower;

    bool farstInput;

    private void Start()
    {
        farstInput = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (InputManager.GetMouseLeftButton(InputManager.SelectObject.Tower, out m_selectTower))
            {
                if (m_lateSelectTower != null && m_lateSelectTower != m_selectTower)
                {
                    m_lateSelectTower.GetComponent<Tower>().UIDisable();
                }
                m_selectTower.GetComponent<Tower>().UIStateChange();
                m_lateSelectTower = m_selectTower;
                if (farstInput == true)
                {
                    m_talentTutorial.SetActive(true);
                    farstInput=false;
                    Invoke(nameof(HideTutorial), 3);
                }
            }
            else if (InputManager.GetMouseLeftButton(InputManager.SelectObject.GameUI,out _) == false)
            {
                if (m_lateSelectTower != null)
                {
                    m_lateSelectTower.GetComponent<Tower>().UIDisable();
                }
            }
        }
    }

    void HideTutorial()
    {
        m_talentTutorial.SetActive(false);
    }
}
