using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager manager;
    public float speed;
    float horizontal;
    float vertical;
    void Start()
    {
        horizontal = Random.Range(-1f, 1f);
        vertical = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(horizontal, vertical).normalized;

        transform.position += direccion * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Vertical")
        {
            horizontal = horizontal * -1;
        }
        if (collision.gameObject.tag == "Horizontal")
        {
            vertical = vertical * -1;
        }
        if(collision.gameObject.tag == "PorteriaA") 
        {
            Spawn();
            manager.puntA++;
        }
        if (collision.gameObject.tag == "PorteriaB")
        {
            Spawn();
            manager.puntB++;
        }
    }
    void Spawn()
    {
        transform.position = new Vector3(0, 0, 0);
        horizontal = Random.Range(-1f, 1f);
        if (horizontal < 0f)
        {
            horizontal = -1;
        }
        else
        {
            horizontal = 1;
        }
        vertical = Random.Range(-1f, 1f);
    }
}
