using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectMoney : MonoBehaviour
{
    public GameObject CoinsText;
    public static int Score;

    // Update is called once per frame

    void Update()
    {
       // Debug.Log("-> Inside CollectMoney OnTriggerEnter() \n");

        //if (other.tag == "MainCharacter")
        //{
        //    Score++;
            CoinsText.GetComponent<Text>().text = "Coins: " + Score;
       // }
    }
}
