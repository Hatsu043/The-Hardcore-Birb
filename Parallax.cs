using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;  //Speed for animation background

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>(); 
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);  //Move background with animationSpeed
    }
}
