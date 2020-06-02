using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamr : MonoBehaviour
{   
    void Start()
    {
        Debug.Log("itworks");
        SceneManager.LoadScene(2);
    }

}
