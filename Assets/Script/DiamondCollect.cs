using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondCollect : MonoBehaviour
{
    private int Diamond = 0; //�ӹǹ����­

    public TextMeshProUGUI diamondtext;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Diamond")
        {
            Diamond++; //�ǡ����­
            diamondtext.text = "Diamond: " + Diamond.ToString();
            Debug.Log(Diamond);
            Destroy(other.gameObject); //������­
        }
    }
}
