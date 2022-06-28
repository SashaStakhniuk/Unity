using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutScene : MonoBehaviour
{
    public void GoBack()
    {
        Debug.Log("GoBack was clicked\n");
        SceneManager.LoadScene("Scenes/Menu");
    }
}
