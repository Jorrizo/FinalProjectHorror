using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject resumeSelect;
    public GameObject quitSelect;

    bool resumeSelected;

    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
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

        if (GameIsPaused)
        {
            if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.S))
            {
                if(resumeSelected == true)
                {
                    quitSelect.SetActive(true);
                    resumeSelect.SetActive(false);
                    resumeSelected = false;
                }
                else
                {
                    quitSelect.SetActive(false);
                    resumeSelect.SetActive(true);
                    resumeSelected = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(resumeSelected == true)
                {
                    ContinueGame();
                }
                else
                {
                    GoBack();
                }
            }
        }
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        quitSelect.SetActive(false);
        resumeSelect.SetActive(true);
        resumeSelected = true;
    }

    public void ContinueGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    public void GoBack()
    {
        Debug.Log("italsoworks");
        SceneManager.LoadScene(0);
    }
}
