using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class CoinsController : MonoBehaviour
{
    public GameObject CoinsScoreText;
    public int Score;
    //public AudioSource collectCoinSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //collectCoinSound.Play();
        //Score += 10;
        //Destroy(GameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("-> Inside CoinsController OnTriggerEnter() \n");

        if (other.tag == "Character")
        {
            int currentMoneyAmount = 0;
            string money = CoinsScoreText.GetComponent<Text>().text;
            if (!String.IsNullOrEmpty(money))
            {
                currentMoneyAmount = Int32.Parse(money);
                Debug.Log("-> currentMoneyAmount = " + currentMoneyAmount + "\n");
                Debug.Log("-> inputMoney = " + money + "\n");
                Debug.Log("-> Score: " + Score + "\n");

                currentMoneyAmount += Score;
                Debug.Log("-> currentMoneyAmount = " + currentMoneyAmount + "\n");
                Destroy(gameObject);
                CoinsScoreText.GetComponent<Text>().text = currentMoneyAmount.ToString();
            }

        }
    }
}
