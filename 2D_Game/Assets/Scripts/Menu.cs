using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.UI;
public class Menu : MonoBehaviour
{
    public void OpenMenu()
    {
        //Scene scene = SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("Menu");
    }
    public void Play()
    {
        //Scene scene = SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("Level1");
    }
    public void Level1()
    {
        //Scene scene = SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        //Scene scene = SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        //Scene scene = SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("Level3");
    }
    public void Exit()
    {
        Application.Quit();
    }
    void Start()
    {
        Player.SetDefaultValues();
    }
}
