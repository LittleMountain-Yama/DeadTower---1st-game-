using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public void GoToLvl1()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void GoToStart1()
    {
        SceneManager.LoadScene("Start1");
    }
    public void GoToStart2()
    {
        SceneManager.LoadScene("Start2");
    }
    public void GoToLvl2()
    {
        SceneManager.LoadScene("Lvl2");
    }
    public void GoToStages()
    {
        SceneManager.LoadScene("Stages");
    }
    public void GoToInfoScene()
    {
        SceneManager.LoadScene("InfoScene");
    }
    public void Exit()

    {
        Application.Quit();
    }

}
