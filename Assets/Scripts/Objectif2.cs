using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif2 : MonoBehaviour
{
    public GameObject scaphandre;


    void Start()
    {
        Debug.Log("itworks2");
        scaphandre.SetActive(false);
    }
}
