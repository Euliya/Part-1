using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cat : MonoBehaviour
{
    Vector2 direction;
    public float speed;
    Rigidbody2D rigidbody;

    public GameObject firePrefab;
    public Transform mouth;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         direction.x = Input.GetAxis("Horizontal");
         direction.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(firePrefab, mouth.position, mouth.rotation);
        }

    }
   void FixedUpdate()
    {
        rigidbody.AddForce(direction * speed * Time.deltaTime);
    }
}
