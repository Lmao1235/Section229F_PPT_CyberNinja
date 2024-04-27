using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private GameObject Player;
    private Rigidbody2D rb;
    [SerializeField] private float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = Player.transform.position - transform.position;
        rb.velocity = new Vector2 (direction.x, direction.y).normalized * force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
