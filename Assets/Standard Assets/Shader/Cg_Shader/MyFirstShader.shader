Shader "Holistic/AllProps" 
{
    Properties {

        _myDiffuseTex ("Diffuse Texture", 2D) = "white" {}
        _myBumb ("Normal Texture", 2D) = "bumb" {}
		    _mySlider ("Bumb Amount", Range(0,10))= 1
		    _myAlbedoSlider ("Albedo Amount", Range(0,10))= 1

    }
    SubShader {

      CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _myDiffuseTex;
        sampler2D _myBumb;
		    half _mySlider;
		    half _myAlbedoSlider;

        struct Input {
            float2 uv_myDiffuseTex;
            float2 uv_myBumb;

        };
        
        void surf (Input IN, inout SurfaceOutput o) {
            o.Albedo = tex2D(_myDiffuseTex, IN.uv_myDiffuseTex * _myAlbedoSlider).rgb;
            o.Normal = UnpackNormal(tex2D(_myBumb, IN.uv_myBumb));
            o.Normal *= float3(_mySlider, _mySlider, 1);

           
        }
      
      ENDCG
    }
    Fallback "Diffuse"
  }
