using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControll : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float x; 
    public float y;
    public float speed=5f;

    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (x*speed,y*speed);
    }
}
