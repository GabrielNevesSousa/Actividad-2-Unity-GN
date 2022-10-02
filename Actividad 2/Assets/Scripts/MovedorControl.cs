using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{
    public Transform[] personajes;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        for (int a = 0; a < personajes.Length; a++) { 
        if(personajes[0].Equals(Input.GetKey(KeyCode.Alpha1)))
        {
           
            }
            
        }

    }
}
