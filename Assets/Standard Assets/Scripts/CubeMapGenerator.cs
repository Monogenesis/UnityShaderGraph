using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class CubeMapGenerator : MonoBehaviour
{

    public Transform renderFromPosition;
    public Cubemap cubemap;

    public Camera cam;

    private void Awake()
    {
        //cubemap = new Cubemap(512, TextureFormat.RGBA32, false);
    }

    private void Start()
    {
        cam.transform.rotation = Quaternion.identity;
        cam.RenderToCubemap(cubemap, 63);
        CreateCubeMap();
    }


    void CreateCubeMap()
    {
        var tex = new Texture2D(cubemap.width, cubemap.height, TextureFormat.RGB24, false);
        // Read screen contents into the texture        
        tex.SetPixels(cubemap.GetPixels(CubemapFace.PositiveX));
        // Encode texture into PNG
        var bytes = tex.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/" + cubemap.name + "_PositiveX.png", bytes);
        tex.SetPixels(cubemap.GetPixels(CubemapFace.NegativeX));
        bytes = tex.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/" + cubemap.name + "_NegativeX.png", bytes);
        tex.SetPixels(cubemap.GetPixels(CubemapFace.PositiveY));
        bytes = tex.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/" + cubemap.name + "_PositiveY.png", bytes);
        tex.SetPixels(cubemap.GetPixels(CubemapFace.NegativeY));
        bytes = tex.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/" + cubemap.name + "_NegativeY.png", bytes);
        tex.SetPixels(cubemap.GetPixels(CubemapFace.PositiveZ));
        bytes = tex.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/" + cubemap.name + "_PositiveZ.png", bytes);
        tex.SetPixels(cubemap.GetPixels(CubemapFace.NegativeZ));
        bytes = tex.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/" + cubemap.name + "_NegativeZ.png", bytes);
        DestroyImmediate(tex);
    }

}


