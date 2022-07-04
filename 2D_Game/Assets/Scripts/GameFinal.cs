using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinal : MonoBehaviour
{
    public GameObject GamePassedPanel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Character")
        {
            GamePassedPanel.SetActive(true);

            //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            //if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
            //{
            //    SceneManager.LoadScene(nextSceneIndex);
            //}
            //else
            //{
            //    SceneManager.LoadScene("Menu");
            //}
            //Debug.Log("\n-> NextLevel!\n");
            // SceneManager.LoadScene("Level2");
        }
    }
}
