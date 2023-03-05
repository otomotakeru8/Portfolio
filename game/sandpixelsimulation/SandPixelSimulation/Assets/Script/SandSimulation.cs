using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class SandSimulation
{
    static bool m_adjustment1 = true;
    static bool m_adjustment2 = true;
    static bool m_adjustment3 = true;

    //ÉfÉäÉQÅ[ÉgÇ…äiî[ÇµåƒÇ—èoÇ≥ÇÍÇÈ
    public static void UpData(int x, int y)
    {
        if (Test01Pixel.GetPixelType(x, y - 1) == air)
        {
            /*if (Test01Pixel.GetPixelType(x, y - 2) == sand)
            {
                m_adjustment1 = !m_adjustment1;
                if (m_adjustment1 == true && Test01Pixel.GetPixelType(x - 1, y - 1) == air)
                {
                    Test01Pixel.SetPixelType(x - 1, y - 1, sand);
                    Test01Pixel.SetPixelType(x, y, air);
                    return;
                }
            }*/
            if (Test01Pixel.GetPixelType(x, y - 2) == sand)
            {
                if (Test01Pixel.GetPixelType(x + 1, y - 1) == air)
                {
                    Test01Pixel.SetPixelType(x + 1, y - 1, sand);
                    Test01Pixel.SetPixelType(x, y, air);
                    return;
                }
            }
            Test01Pixel.SetPixelType(x, y - 1, sand);
            Test01Pixel.SetPixelType(x, y, air);
        }
        else if (Test01Pixel.GetPixelType(x - 1, y - 1) == air)
        {
            m_adjustment3 = !m_adjustment3;
            if (m_adjustment3 == true && Test01Pixel.GetPixelType(x - 1, y + 1) == air)
            {
                Test01Pixel.SetPixelType(x - 1, y + 1, sand);
                Test01Pixel.SetPixelType(x, y, air);
                return;
            }
            Test01Pixel.SetPixelType(x - 1, y - 1, sand);
            Test01Pixel.SetPixelType(x, y, air);
        }
        else if (Test01Pixel.GetPixelType(x + 1, y - 1) == air)
        {
            m_adjustment2 = !m_adjustment2;
            if (m_adjustment2 == true && Test01Pixel.GetPixelType(x + 1, y + 1) == air)
            {
                Test01Pixel.SetPixelType(x + 1, y + 1, sand);
                Test01Pixel.SetPixelType(x, y, air);
                return;
            }
            Test01Pixel.SetPixelType(x + 1, y - 1, sand);
            Test01Pixel.SetPixelType(x, y, air);
        }
    }
}
