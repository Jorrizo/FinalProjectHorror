using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineHidingSpot : MonoBehaviour
{
    public GameObject[] childObjects;

    void Start()
    {
        for (int i = 0; i < childObjects.Length; i++)
        {
            childObjects[i].GetComponent<Outline>().OutlineColor = Color.red;
            childObjects[i].GetComponent<Outline>().OutlineWidth = 4f;
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
