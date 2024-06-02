Shader "Custom/CubeReflect" {
	Properties {
        _MainTint ("Main Color", Color) = (1, 1, 1, 1)
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _CubeMap ("Cube Map", CUBE) = ""{}
        _ReflPower("Refl Power", Range(0, 1)) = 0.5
    }
    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;
        samplerCUBE _CubeMap;
        fixed4 _MainTint;
        fixed _ReflPower;

        struct Input {
            float2 uv_MainTex;
            float3 worldRefl;
        };

        void surf (Input IN, inout SurfaceOutput o) {
            half4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = _MainTint.rgb * c.rgb;
            o.Emission = texCUBE(_CubeMap, IN.worldRefl).rgb * _ReflPower;
            o.Alpha = c.a;
        }
        ENDCG
    }
	FallBack "Diffuse"
}
