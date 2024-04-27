using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform BulletPos;
    private float timer;

    private GameObject Player;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        

        float distance = Vector2.Distance(transform.position, Player.transform.position);
        Debug.Log(distance);

        if(distance < 10)
        {
            timer += Time.deltaTime;

            if (timer > 1)
            {
                timer = 0;
                shoot();
            }
        }

        
    }

    void shoot()
    {
        Instantiate(Bullet, BulletPos.position, Quaternion.identity);
    }
}
