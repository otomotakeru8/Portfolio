using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static Constant;

public class PixelMesh : MonoBehaviour
{
    [SerializeField]
    Shader drawShader;

    public static Material material;

    ComputeBuffer vertexBuffer;
    public static ComputeBuffer colorBuffer;

    public static List<Vector4> _color;

    int start = 0;

    void OnEnable()
    {
        // 頂点を生成
        var points = new List<Vector3>();
        for (int y = start; y < mapY; y++) 
        {
            for (int x = start; x < mapX; x++) 
            {
                points.Add(new Vector3(x, y, 0));
            }
        }
        vertexBuffer = new ComputeBuffer(points.Count, Marshal.SizeOf(typeof(Vector3)), ComputeBufferType.Default);
        vertexBuffer.SetData(points);

        // カラーを生成
        _color = new List<Vector4>();
        for (int i = 0; i < mapX * mapY; i++)
        {
            _color.Add(new Color(0, 0, 0, 0));
        }
        colorBuffer = new ComputeBuffer(_color.Count, Marshal.SizeOf(typeof(Color)), ComputeBufferType.Default);
        colorBuffer.SetData(_color);

        // 描画シェーダーにバッファを設定
        material = new Material(drawShader);
        material.SetBuffer("points", vertexBuffer);
        material.SetBuffer("colors", colorBuffer);
    }

    public static void SetPixelColor(int x, int y, Color color)
    {
        _color[x + y * mapX] = color;
    }

    public static void SetPixelColor(int number, Color color)
    {
        _color[number] = color;
    }

    private void OnDisable()
    {
        vertexBuffer.Release();
        colorBuffer.Release();
        _color.Clear();
    }

    public static void SetColor()
    {
        colorBuffer.SetData(_color);
    }

    void OnRenderObject()
    {
        //colorBuffer.SetData(_color);

        //material.SetBuffer("colors", colorBuffer);

        material.SetPass(0);

        Graphics.DrawProceduralNow(MeshTopology.Points, vertexBuffer.count);
    }
}
