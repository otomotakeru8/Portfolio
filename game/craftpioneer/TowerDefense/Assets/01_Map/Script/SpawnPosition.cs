using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{

    [SerializeField]
    GameObject m_waveButton;
    GameObject m_uiObject;
    GameObject m_canvas;

    // Start is called before the first frame update
    void Start()
    {
        m_canvas = GameObject.Find("Canvas");

        m_uiObject = Instantiate(m_waveButton, m_canvas.transform);
        m_uiObject.GetComponent<SpawnButton>().m_spawnTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
