Shader "Unlit/GalaxyShader2"
{
     Properties
    {
        _GalaxyA ("Texture", 2D) = "white" {}
        _GalaxyB ("Texture", 2D) = "white" {}
        _GalaxyC ("Texture", 2D) = "white" {}
        _NoiceA ("Texture", 2D) = "white" {}
        _NoiceB ("Texture", 2D) = "white" {}
        _NoiceC ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            
            sampler2D _GalaxyA;
            sampler2D _NoiceA; 

            
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                float4 pos : TEXCORD1;
            };


            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                float4 col= float4(1,1,1,1);
                col.xyz = tex2D(_GalaxyA, i.uv + _Time/20).xyz;
                col.w = tex2D(_NoiceA, i.uv+ _Time/20 + _CosTime/8).x*.2 ;

                return col;
            }
            ENDCG
        }
    }
    
   SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100        
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            
            sampler2D _GalaxyB;
            sampler2D _NoiceB; 

            
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                float4 pos : TEXCORD1;
            };


            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                float4 col= float4(1,1,1,1);
                col.x = tex2D(_GalaxyB, i.uv + _Time/20).x;
                col.y = tex2D(_NoiceB, i.uv+ _Time/20 + _CosTime/8).x*.2 ;

                return col;
            }
            ENDCG
        }
    }
}
