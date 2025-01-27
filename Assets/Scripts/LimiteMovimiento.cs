using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float yMax = 6;
    public float yMin = -6;
    public float xMin = 0;
    public float xMax = 0;
    void Update()
    {
        if (transform.position.y > yMax)
        {
            Debug.Log("Me he pasado Y+");
            transform.position = new Vector3(transform.position.x, yMax);
        }
        if (transform.position.y < yMin)
        {
            Debug.Log("Me he pasado Y-");
            transform.position = new Vector3(transform.position.x, yMin);
        }
        if (transform.position.x > xMax)
        {
            Debug.Log("Me he pasado X+");
            transform.position = new Vector3(xMax, transform.position.y);
        }
        if (transform.position.x < xMin)
        {
            Debug.Log("Me he pasado X-");
            transform.position = new Vector3(xMin, transform.position.y);
        }
    }
}
