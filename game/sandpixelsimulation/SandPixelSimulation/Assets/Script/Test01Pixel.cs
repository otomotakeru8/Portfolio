using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static Constant;

static class Test01Pixel
{
    //物質の種類
    public static int[,] m_type = new int[mapX, mapY];
    static int[,] m_lateType = new int[mapX, mapY];

    //明るさ
    static int[,] m_lighting;

    //シミュレーションするピクセル
    static bool[,] m_activePixels = new bool[mapX, mapY];

    public static int GetPixelType(int x, int y)
    {
        return m_type[x, y];
    }

    public static void SetPixelType(int x, int y, int type)
    {
        m_type[x, y] = type;
        SetColorByType(x, y, type);
    }

    public static void SetPixelActive(int x, int y, bool value)
    {
        m_activePixels[x, y] = value;
    }


    public static void SetColorByType(int x, int y, int type)
    {
        switch (type)
        {
            case air:
                PixelMesh.SetPixelColor(x, y, color_Air);
                SetPixelActive(x, y, false);
                break;
            case rock:
                SetPixelActive(x, y, false);
                PixelMesh.SetPixelColor(x, y, color_Rock);
                break;
            case sand:
                PixelMesh.SetPixelColor(x, y, color_Sand);
                SetPixelActive(x, y, true);
                break;
        }
    }

    public static void SetColorByType(int number, int type)
    {
        switch (type)
        {
            case air:
                PixelMesh.SetPixelColor(number, color_Air);
                SetPixelActive(number % mapX, number / mapX, false);
                break;
            case rock:
                PixelMesh.SetPixelColor(number, color_Rock);
                SetPixelActive(number % mapX, number / mapX, false);
                break;
            case sand:
                PixelMesh.SetPixelColor(number, color_Sand);
                SetPixelActive(number % mapX, number / mapX, true);
                break;
        }
    }

    public static void PixelInit()
    {
        for (int x = 0; x < mapX; x++)
        {
            for (int y = 0; y < mapY; y++)
            {
                m_type[x, y] = air;
                m_lateType[x, y] = air;
            }
        }
    }

    public static void PhysicsSimulation()
    {
        for (int y = 0; y < mapY; y++)
        {
            for (int x = mapX - 1; x >= 0; x--)
            {
                if (m_activePixels[x, y] == true && m_type[x, y] == sand)
                {
                    //並列化もしくは剛体と流体を分けるかタグを作る
                    SandSimulation.UpData(x, y);
                }
            }
        }
        //_lateType = m_type;
    }
}
