using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class AddHealtScript : MonoBehaviour
{
    public GameObject HealthText;
    public int Health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //HealthText.GetComponent<Text>().text = Health +" hp";
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("-> Inside AddHealtScript OnTriggerEnter() \n");

        if (other.tag == "MainCharacter")
        {
            int currentHealth = 0;
            string hp = HealthText.GetComponent<Text>().text;
            if (!String.IsNullOrEmpty(hp))
            {
                currentHealth = Int32.Parse(hp);
                Debug.Log("-> currentHealth = "+ currentHealth + "\n");
                Debug.Log("-> inputHealth = " + Health + "\n");

                currentHealth += Health;
                Debug.Log("-> currentHealth = " + currentHealth + "\n");


                if (currentHealth > 100)
                {
                    currentHealth = 100;
                }
                else if (currentHealth <= 0)
                {
                    currentHealth = 0;
                    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
                }
            }
            Debug.Log("-> Health picked up\n");
            HealthText.GetComponent<Text>().text = currentHealth.ToString();
            Destroy(gameObject);
        }
    }
}
