using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class Test01Main : MonoBehaviour
{
    bool m_wait;

    [SerializeField]
    Text m_FpsText;
    float[] m_fpsData;
    int m_fpsDataPointer;

    [SerializeField]
    ComputeShader m_computeShader;
    int[] m_mapData;


    // Start is called before the first frame update
    void Start()
    {
        m_fpsData = new float[50];
        Test01Pixel.PixelInit();
        Application.targetFrameRate = 1000;
        Initialized();
    }

    void Initialized()
    {
        for (int i = 0; i < mapX; i++)
        {
            Test01Pixel.SetPixelType(i, 0, rock);
        }
        for (int y = 0; y < mapY; y++)
        {
            Test01Pixel.SetPixelType(0, y, rock);
            Test01Pixel.SetPixelType(mapX - 1, y, rock);
        }
        m_mapData = new int[600000];
        PixelMesh.SetColor();
        m_computeShader.SetBuffer(0, "typeMap", PixelMesh.colorBuffer);
    }

    // Update is called once per frame
    void Update()
    {
        m_fpsData[m_fpsDataPointer] = Time.deltaTime;
        m_fpsDataPointer++;
        if (m_fpsDataPointer == 50)
        {
            m_fpsDataPointer = 0;
        }
        m_FpsText.text = (1 /m_fpsData.Average()).ToString();

        if (SystemInfo.supportsComputeShaders == true)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Vector2 mPos = Input.mousePosition;
                m_computeShader.SetInt("x", (int)(mPos.x / 1.93));
                m_computeShader.SetInt("y", (int)(mPos.y / 1.92));
            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                m_computeShader.SetInt("x", 0);
                m_computeShader.SetInt("y", 0);
            }

            if (Input.GetKey(KeyCode.Mouse1))
            {
                Vector2 mPos = Input.mousePosition;
                m_computeShader.SetInt("x", (int)(mPos.x / 1.93));
                m_computeShader.SetInt("y", (int)(mPos.y / 1.92));
                m_computeShader.SetBool("erase", true);
            }
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                m_computeShader.SetInt("x", 0);
                m_computeShader.SetInt("y", 0);
                m_computeShader.SetBool("erase", false);
            }

            m_computeShader.SetInt("frame", Time.frameCount);
            m_computeShader.Dispatch(0, 125, 75, 1);
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Vector2 mPos = Input.mousePosition;
                Test01Pixel.SetPixelType((int)(mPos.x / 1.8), (int)(mPos.y / 1.92), sand);
                Test01Pixel.SetPixelType((int)(mPos.x / 1.8), (int)(mPos.y / 1.92) + 1, sand);
                Test01Pixel.SetPixelType((int)(mPos.x / 1.8) + 1, (int)(mPos.y / 1.92), sand);
                Test01Pixel.SetPixelType((int)(mPos.x / 1.8) + 1, (int)(mPos.y / 1.92) + 1, sand);
            }

            if (Input.GetKey(KeyCode.Mouse1))
            {
                Vector2 mPos = Input.mousePosition;
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        Test01Pixel.SetPixelType((int)(mPos.x / 1.8) + x, (int)(mPos.y / 1.92) + y, air);
                    }
                }
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (m_wait == false || m_wait == true)
                {
                    for (int i = 0; i < 300; i += 2)
                    {
                        Test01Pixel.SetPixelType(i + 200, 400, sand);
                    }
                }
                m_wait = !m_wait;
            }

            Test01Pixel.PhysicsSimulation();
            PixelMesh.SetColor();
        }
    }

    public void ChangeFpsLimit()
    {
        if (Application.targetFrameRate == 60)
        {
            Application.targetFrameRate = 1000;
        }
        else
        {
            Application.targetFrameRate = 60;
        }
    }

    public void ReStart()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
