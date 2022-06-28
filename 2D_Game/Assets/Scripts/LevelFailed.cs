using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFailed : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Character")
        {
            Debug.Log("\n-> TryAgain!\n");
            SceneManager.LoadScene("Demo");
        }
    }
}
