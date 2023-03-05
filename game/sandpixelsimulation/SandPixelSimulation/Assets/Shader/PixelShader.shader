Shader "Custom/PixelShader"
{
        SubShader
    {
        Tags {"Queue" = "Geometry" "RenderType" = "Opaque"}
        Pass
        {
            Tags {"LightMode" = "ForwardBase"}
            CGPROGRAM

            uniform StructuredBuffer<float3>    points;
            uniform StructuredBuffer<float4>    colors;

            #pragma vertex vert
            #pragma geometry geom
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "UnityLightingCommon.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct VSOut {
                fixed4 diff : COLOR0;
                float4 pos : SV_POSITION;
            };


            // ジオメトリシェーダ
            [maxvertexcount(4)]
            void geom(point VSOut input[1], inout TriangleStream<VSOut> outStream)
            {
                VSOut output;
                float4 pos = input[0].pos;
                float4 diff = input[0].diff;
                {
                    output.pos = mul(UNITY_MATRIX_VP, pos + float4(0, 0, 0, 1));
                    output.diff = diff;
                    outStream.Append(output);
                    output.pos = mul(UNITY_MATRIX_VP, pos + float4(0, 1, 0, 1));
                    output.diff = diff;
                    outStream.Append(output);
                    output.pos = mul(UNITY_MATRIX_VP, pos + float4(1, 0, 0, 1));
                    output.diff = diff;
                    outStream.Append(output);
                    output.pos = mul(UNITY_MATRIX_VP, pos + float4(1, 1, 0, 1));
                    output.diff = diff;
                    outStream.Append(output);
                    outStream.RestartStrip();
                }
            }

            // 頂点シェーダ
            VSOut vert(uint id : SV_VertexID)
            {
                VSOut output;
                output.pos = float4(points[id], 1);
                output.diff = colors[id];
                return output;
            }

            // ピクセルシェーダー
            fixed4 frag(VSOut i) : COLOR
            {
                return i.diff;
            }
            ENDCG
        }
    }
}
