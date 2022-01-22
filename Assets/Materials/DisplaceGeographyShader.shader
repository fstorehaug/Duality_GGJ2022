Shader "Custom/DisplaceGeography"
{
    Properties
    {
        _Radius("radius", float) = 0
        _WorldSpaceCenterFrom("position_From", vector) = (0,0,0,0) 
        _WorldSpaceCenterTo("position_To", vector) = (0,0,0,0) 
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200
        
        pass
        {
            CGPROGRAM
            // Physically based Standard lighting model, and enable shadows on all light types
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            
            sampler2D _MainTex;
            float _Radius;
            float4 _WorldSpaceCenterTo;
            float4 _WorldSpaceCenterFrom;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = v.vertex;
                //pos to worldspace
                o.vertex =  mul(unity_ObjectToWorld, o.vertex);
                //pos in sircle ? if yes add the vector from the point you are in to the point you are going to
                o.vertex = o.vertex + ((distance(o.vertex, _WorldSpaceCenterFrom) < _Radius) * (( o.vertex - _WorldSpaceCenterFrom) + (_WorldSpaceCenterTo) + float4(0,0,0,0)));
                o.vertex = UnityWorldToClipPos(o.vertex);
                
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                return col;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
