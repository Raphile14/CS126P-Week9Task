using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{

    public float speed;
    public float limit;

    void Start()
    {
        transform.position = new Vector3(-limit, 5, 0);
    }

    void Update()
    {
        if (transform.position.x >= limit)
        {
            transform.position = new Vector3 (-limit, 5, 0);
        }
        transform.position = new Vector3 (transform.position.x + speed * Time.deltaTime, 5, 0);
    }
}
