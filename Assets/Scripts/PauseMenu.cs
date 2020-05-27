using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject hidingCamera;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        hidingCamera.GetComponent<HidingRaycast>().enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ContinueGame();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        hidingCamera.GetComponent<HidingRaycast>().enabled = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ContinueGame()
    {
        pauseMenuUI.SetActive(false);
        hidingCamera.GetComponent<HidingRaycast>().enabled = true;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Restart()
    {
        Debug.Log("itworks");
        SceneManager.LoadScene(1);
    }

    public void GoBack()
    {
        Debug.Log("italsoworks");
        SceneManager.LoadScene(0);
    }
}
