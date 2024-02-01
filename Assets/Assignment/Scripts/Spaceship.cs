using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveHor = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");
        transform.Translate(moveHor * speed * Time.deltaTime, moveVer * speed * Time.deltaTime, 0);
    }
}
