using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{
    public Transform[] personajes;
    public MeshRenderer meshRenderer;
    public Color color;
    int eleccion = -1;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Alpha1))
        {
            eleccion = 0;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            eleccion = 1;
        }else if (Input.GetKey(KeyCode.Alpha3)){
            eleccion = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha4)){
            eleccion = 3;
        }
   

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            personajes[eleccion].position += Vector3.left;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            personajes[eleccion].position += Vector3.down;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            personajes[eleccion].position += Vector3.right;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            personajes[eleccion].position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            foreach (Transform obj in personajes)
            {
                obj.transform.position = new Vector3(0, 0, 0);
            }
        }


    }





}



