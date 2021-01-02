using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawner;
    public GameObject Sphere;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnsSphere", 0, (0.1f/counter));
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnsSphere()
    {
        Instantiate(Sphere, transform.position, transform.rotation);
    }
}
