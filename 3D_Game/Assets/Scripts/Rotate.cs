using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public GameObject CoinsText;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game is started!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(3 * Time.deltaTime, 5, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("-> Inside Rotate OnTriggerEnter() \n");

        if (other.tag == "MainCharacter")
        {
            CollectMoney.Score++;
            Debug.Log("-> Coin picked up\n");
            CoinsText.GetComponent<Text>().text = "Coins: "+Score;
            Destroy(gameObject);
        }
    }
}
