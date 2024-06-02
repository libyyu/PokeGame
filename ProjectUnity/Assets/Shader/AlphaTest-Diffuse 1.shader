Shader "Custom/CubeRefl" {
    Properties {
        _MainTint ("Main Color", Color) = (1, 1, 1, 1)
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _CubeMap ("Cube Map", CUBE) = ""{}
        _ReflPower("Refl Power", Range(0, 1)) = 0.5
        _FresnelPower("Frensnel Power", Range(0.1, 5)) = 2
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
        fixed _FresnelPower;

        struct Input {
            float2 uv_MainTex;
            float3 worldRefl;
            float3 viewDir;
        };

        void surf (Input IN, inout SurfaceOutput o) {
            half4 c = tex2D (_MainTex, IN.uv_MainTex);
            fixed diff = 1.0 - saturate(dot(o.Normal, normalize(IN.viewDir)));
            diff = pow(diff, _FresnelPower);
            o.Albedo = _MainTint.rgb * c.rgb;
            o.Emission = texCUBE(_CubeMap, IN.worldRefl).rgb * diff * _ReflPower;
            o.Alpha = c.a;
        }
        ENDCG
    } 
    FallBack "Diffuse"
}