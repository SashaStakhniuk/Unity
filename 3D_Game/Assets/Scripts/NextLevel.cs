using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game is started!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Program Here!");

        if (other.tag == "MainCharacter")
        {
            Destroy(gameObject);
            Debug.Log("Object is destroy! We are transform to a new scene!");
            SceneManager.LoadScene("Scenes/Level2");
        }
    }
}
