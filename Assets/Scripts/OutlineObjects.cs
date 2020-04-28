using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineObjects : MonoBehaviour
{
    public GameObject parentObject;

    void Update()
    {
        if(parentObject.GetComponent<Outline>().enabled == true)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }
}
