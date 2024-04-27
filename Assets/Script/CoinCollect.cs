using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private int Gold = 0; //จำนวนเหรียญ

    public TextMeshProUGUI cointext;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Gold")
        {
            Gold++; //บวกเหรียญ
            cointext.text = "Gold: " + Gold.ToString();
            Debug.Log(Gold);
            Destroy(other.gameObject); //เก็บเหรียญ
        }
    }
}
