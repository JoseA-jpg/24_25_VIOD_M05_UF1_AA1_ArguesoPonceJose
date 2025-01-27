using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movimiento2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed;
    public bool JugadorA;
    void Update()
    {
        float horizontal;
        float vertical;
        
        if(JugadorA)
        {
            horizontal = Input.GetAxis("HorizontalA");
            vertical = Input.GetAxis("VerticalA");
        }
        else
        {
            horizontal = Input.GetAxis("HorizontalB");
            vertical = Input.GetAxis("VerticalB");
        }

        Vector3 direccion = new Vector3(horizontal, vertical);
        transform.position += direccion * speed * Time.deltaTime;

    }
}
