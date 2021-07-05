using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MeshHighlighter : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    void Start()

    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseEnter()
    {
        meshRenderer.material.SetFloat("ToggleHighlight", 1.0f);
    }
    private void OnMouseExit()
    {
        meshRenderer.material.SetFloat("ToggleHighlight", 0.0f);
    }

}
