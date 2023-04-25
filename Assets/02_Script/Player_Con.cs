using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float add_position;

    void Start()
    {

    }

    void Update()
    { 
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x + add_position, transform.position.y + add_position, transform.position.z);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x - add_position, transform.position.y - add_position, transform.position.z);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + add_position, transform.position.y - add_position, transform.position.z);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - add_position, transform.position.y + add_position, transform.position.z);
        }

    }

   
}