using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Character")
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                SceneManager.LoadScene("Menu");
            }
            Debug.Log("\n-> NextLevel!\n");
           // SceneManager.LoadScene("Level2");
        }
    }
}
