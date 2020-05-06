using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineHidingSpot : MonoBehaviour
{
    public GameObject[] childObjects;

    void Start()
    {
        if(gameObject.CompareTag("Interactive"))
        {
            for (int i = 0; i < childObjects.Length; i++)
            {
                childObjects[i].GetComponent<Outline>().OutlineColor = Color.blue;
                childObjects[i].GetComponent<Outline>().OutlineWidth = 4f;
            }
        }
        else if(gameObject.CompareTag("Quest"))
        {
            for (int i = 0; i < childObjects.Length; i++)
            {
                childObjects[i].GetComponent<Outline>().OutlineColor = Color.red;
                childObjects[i].GetComponent<Outline>().OutlineWidth = 4f;
            }
        }
    }

    public void ActivateOutline()
    {
        for(int i = 0; i<childObjects.Length;  i++)
        {
            childObjects[i].GetComponent<Outline>().enabled = true;
        }
    }

    public void DeactivateOutline()
    {
        for (int i = 0; i < childObjects.Length; i++)
        {
            childObjects[i].GetComponent<Outline>().enabled = false;
        }
    }
}
