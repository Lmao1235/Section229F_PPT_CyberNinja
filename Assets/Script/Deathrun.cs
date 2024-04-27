using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathrun : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    void Start()
    {
        // Set initial velocity to make the object move right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
}
