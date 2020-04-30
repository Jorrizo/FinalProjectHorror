using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public static int objectivesDone;

    void Start()
    {
        objectivesDone = 0;
    }
}
