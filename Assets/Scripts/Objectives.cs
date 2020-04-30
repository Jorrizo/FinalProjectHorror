using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
    public int objectiveNumber;
   

    void Update()
    {
       /* if(objectiveNumber != GameManager.objectivesDone)
        {
            gameObject.tag = "Objectif";
        }
        else
        {
            gameObject.tag = "Quest";
        }*/
    }

    public void Interact()
    {
        if(objectiveNumber == GameManager.objectivesDone)
        {
            Debug.Log(GameManager.objectivesDone);
            GameManager.objectivesDone++;
            Debug.Log(GameManager.objectivesDone);
        }
        else
        {
            Debug.Log("Nope");
        }
    }
  
}
