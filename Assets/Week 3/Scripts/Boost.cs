using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public GameObject car;
    public float boostSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Car>().maxSpeed = boostSpeed;
        collision.gameObject.GetComponent<Car>().forwardSpeed = boostSpeed;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Car>().maxSpeed = 500;
        collision.gameObject.GetComponent<Car>().forwardSpeed = 500;
    }
}
