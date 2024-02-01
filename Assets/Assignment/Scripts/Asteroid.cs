using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speedMin = 1;
    public float speedMax = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (new Vector3 (0, Random.Range(speedMin, speedMax), 0) * Time.deltaTime);
        transform.Rotate(new Vector3 (0, 0, Random.Range(0, 360)) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
