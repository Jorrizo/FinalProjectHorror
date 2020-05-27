using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject buttonReset;

    private void Start()
    {
        buttonReset.SetActive(false);
    }

    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonReset()
    {
        buttonReset.SetActive(true);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }
}
