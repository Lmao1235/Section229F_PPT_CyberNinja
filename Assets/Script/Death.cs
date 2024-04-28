using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] private int SceneBuild;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "EnemyBullet(Clone)" || collision.gameObject.name == "Explosion(Clone)" || collision.gameObject.name == "Lava")
        {
            SceneManager.LoadScene(SceneBuild, LoadSceneMode.Single);
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Deathtrap"))
        {
            SceneManager.LoadScene(SceneBuild, LoadSceneMode.Single);
        }
    }
}
