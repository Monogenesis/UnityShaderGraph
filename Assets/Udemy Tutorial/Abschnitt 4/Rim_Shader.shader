Shader "Holistic/Rim" {

    Properties {
        _myDiffuseTex ("Diffuse Texture", 2D) = "white" {}
        _RimColor ("Rim Color", Color) = (0, 0.5, 0.5, 0.0)
        _RimPower ("Rim Power", Range(0.5, 8.0)) = 3.0
        _StripeSize ("Stripe Size", Range(0.0, 20.0)) = 1.0
    }
    SubShader {

      CGPROGRAM
        #pragma surface surf Lambert

        struct Input {
            float2 uv_myDiffuseTex;
            float3 viewDir;
            float3 worldPos;
        };

        sampler2D _myDiffuseTex;
        float4 _RimColor;
        float _RimPower;
        float _StripeSize;
        
        void surf (Input IN, inout SurfaceOutput o) {
            half rim = 1 - saturate(dot(normalize(IN.viewDir), o.Normal));
            o.Albedo = tex2D(_myDiffuseTex, IN.uv_myDiffuseTex).rgb;
            o.Emission = frac(IN.worldPos.y * _StripeSize * 0.5) > 0.4 ? float3(0,1,0) * rim : float3 (1,0,0) * rim;
        }
      
      ENDCG
    }
    Fallback "Diffuse"
  }
