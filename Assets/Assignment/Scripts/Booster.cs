using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public GameObject spaceship;
    public float boosterSpeed = 50;
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
        
        collision.gameObject.GetComponent<Spaceship>().speed = boosterSpeed;
        collision.gameObject.GetComponent<Spaceship>().maxSpeed = boosterSpeed;
        Destroy(gameObject);
    }
}
