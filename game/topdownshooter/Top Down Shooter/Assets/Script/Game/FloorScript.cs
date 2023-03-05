using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    Renderer m_renderer;
    [SerializeField]
    Material[] m_materials;
    int m_count;

    private void Start()
    {
        m_renderer = GetComponent<Renderer>();
    }

    public void ChangeColor()
    {
        m_renderer.material = m_materials[m_count];
        m_count++;
    }
}
