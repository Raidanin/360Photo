Shader "Custom/NewPanora"
{
    Properties {
        _MainTex ("Texture Array", 2DArray) = "" {}
        _Index ("Index", Float) = 0
    }
    
    SubShader {
        Tags { "Queue"="Background" "RenderType"="Background" "PreviewType"="Skybox" }
        Cull Off ZWrite Off
        
        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            #include "UnityCG.cginc"
            
            UNITY_DECLARE_TEX2DARRAY(_MainTex);
            float _Index;
            
            struct appdata {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
            
            struct v2f {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
            
            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target {
                float3 uvw = float3(i.uv, _Index);
                return UNITY_SAMPLE_TEX2DARRAY(_MainTex, uvw);
            }
            ENDCG
        }
    }
}