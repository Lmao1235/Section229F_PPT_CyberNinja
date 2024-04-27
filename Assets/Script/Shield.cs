using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private Vector3 mousepos;
    private Camera maincam;
    private Rigidbody2D rb;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        maincam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mousepos = maincam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = transform.position - mousepos;
        float rotaze = Mathf.Atan2(-rotation.y, -rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotaze);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            Destroy(gameObject);
        }
    }
}
