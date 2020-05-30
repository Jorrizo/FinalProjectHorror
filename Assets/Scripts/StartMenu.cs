using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject options;
    public GameObject mainMenu;

    private void Start()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
    }

    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonReset()
    {
        options.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }
}
