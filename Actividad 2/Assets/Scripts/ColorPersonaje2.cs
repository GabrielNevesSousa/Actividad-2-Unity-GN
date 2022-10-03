using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPersonaje2 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Alpha2))
        {
            meshRenderer.material.color = color;
        }
        else if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Alpha3) || Input.GetKey(KeyCode.Alpha4))

            meshRenderer.material.color = Color.white;
    }
}
