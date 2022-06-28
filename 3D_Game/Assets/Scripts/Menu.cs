using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.UI;

public class Menu : MonoBehaviour
{


    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/Level1");
    }
    public void AboutGame()
    {
        SceneManager.LoadScene("Scenes/AboutGame");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        Debug.Log("-> Exit button was pressed;\n");
    }

}
