using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    float forwordInput;
    float steeringInput;
    public float steeringSpeed=500;
    public float forwordSpeed=500;
    Rigidbody2D rigidbody;
    public float maxSpeed = 2000;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       forwordInput= Input.GetAxis("Vertical");
       steeringInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
       rigidbody.AddTorque (steeringInput * steeringSpeed * Time.deltaTime);
       Vector2 force=transform.up*forwordSpeed*forwordInput*Time.deltaTime;
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);
        }
           
    }
}
