using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPersonaje1 : MonoBehaviour
{

    public MeshRenderer meshRenderer;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            meshRenderer.material.color = color;
        }
    }
}
