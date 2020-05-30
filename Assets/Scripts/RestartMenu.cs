using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public GameObject options;
    public GameObject menu;

   public void EraseSave()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

    public void GoBack()
    {
        menu.SetActive(true);
        options.SetActive(false);
    }
}
