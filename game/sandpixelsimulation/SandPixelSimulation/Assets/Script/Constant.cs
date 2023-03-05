using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constant
{
    //����
    public const int air = 0;
    public const int rock = 1;
    public const int sand = 2;

    //�}�b�v�̑傫��(ComputeShader�̊֌W�ŌŒ�)
    public const int mapX = 1000;
    public const int mapY = 600;

    //�J���[
    public static Color color_Air = new Color(0, 0, 0, 0);
    public static Color color_Rock = new Color(0.5f, 0.5f, 0.5f, 1);
    public static Color color_Sand = new Color(1, 1, 0, 1);
}
