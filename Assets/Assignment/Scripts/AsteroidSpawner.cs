using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public float astMin = -20;
    public float astMax = 20;
    private float timer = 0;
    public float astSpawnRate = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < astSpawnRate)
        {
            timer += Time.deltaTime;
            
        }
        else
        {
            Instantiate(asteroid, new Vector3(Random.Range(astMin, astMax), 15, 0), transform.rotation);
            timer = 0;
        }

    }
}
