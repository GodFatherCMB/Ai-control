using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    public void Level1(string sceneName)
    {
        SceneManager.LoadScene(1);
    }

    public void Level2(string sceneName)
    {
        SceneManager.LoadScene(2);
    }
    public void Level3(string sceneName)
    {
        SceneManager.LoadScene(3);
    }
    public void Level4(string sceneName)
    {
        SceneManager.LoadScene(4);
    }
    public void Story(string sceneName)
    {
        SceneManager.LoadScene(5);
    }
    public void LevelSelect(string sceneName)
    {
        SceneManager.LoadScene(6);
    }
    public void Exit()
    {
        Application.Quit();
    }
}