using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public float DB;


    private float distance;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);


        if (distance < DB)
        {
            Vector2 direction = Player.transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);


        }


    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Shield")
        {
            Destroy(gameObject);
        }
    }
}