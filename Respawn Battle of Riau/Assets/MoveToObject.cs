using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Cube;
    public float speed;
    public Vector3 movementDirection = new Vector3(1f, 1f, 1f); // Direction in which the object moves

    void Update()
    {
        // Move the object in the specified direction
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
    
}
