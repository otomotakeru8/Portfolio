using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constant
{
    //資材
    public const int air = 0;
    public const int rock = 1;
    public const int sand = 2;

    //マップの大きさ(ComputeShaderの関係で固定)
    public const int mapX = 1000;
    public const int mapY = 600;

    //カラー
    public static Color color_Air = new Color(0, 0, 0, 0);
    public static Color color_Rock = new Color(0.5f, 0.5f, 0.5f, 1);
    public static Color color_Sand = new Color(1, 1, 0, 1);
}
