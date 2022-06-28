using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
//using UnityEditor.UI;
public class CoinSystem : MonoBehaviour
{
    public GameObject ScoreText;
    public static int Score = 10;
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
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("-> Inside CoinSystem OnTriggerEnter() \n");

        if (other.tag == "MainCharacter")
        { 
            Score += 10;
            Debug.Log("-> Score: " + Score + "\n");
            Destroy(gameObject);
            ScoreText.GetComponent<Text>().text = "Score " + Score;

        }
    }

}
