using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamonddie : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            
            Destroy(gameObject); 
        }
    }
}
