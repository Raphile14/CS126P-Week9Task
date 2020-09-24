using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSouthScript : MonoBehaviour
{
    public float speed = 1;
    float z;
    float y;

    void Start()
    {
        y = transform.position.y;
        z = transform.position.z;
    }

    void Update()
    {
        if (transform.position.x <= -5)
        {
            transform.position = new Vector3(5, y, z);
        }
        transform.position = new Vector3(transform.position.x - speed / 10 * Time.deltaTime, y, z);
    }
}
