using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform BulletPos;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 1 )
        {
            timer = 0;
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(Bullet, BulletPos.position, Quaternion.identity);
    }
}
