using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rigidbody;
    Vector2 direction= new Vector2 (10,0);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //transform.Translate(speed * Time.deltaTime, 0, 0);
        
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Missle hit something");
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collisim)
    {
        Debug.Log("trigger something");
    }
}
 