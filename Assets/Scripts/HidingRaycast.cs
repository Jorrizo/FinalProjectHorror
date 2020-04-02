using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HidingRaycast : MonoBehaviour
{
    
    Ray ray;
    RaycastHit hit;

    public bool hidden;

    public int raySize = 10;

    private Transform _selection;


    void Start()
    {


        hidden = false;
    }




    void Update()
    {
       
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(_selection != null)
        {
            _selection.GetComponent<Outline>().enabled = false;
            _selection = null;
        }

        if (Physics.Raycast(ray, out hit, raySize))
        {
            var selection = hit.transform;
            var outlineComponent = selection.GetComponent<Outline>();
            Debug.DrawLine(ray.origin, hit.point);

            if (selection.CompareTag("Interactive"))
            {
                outlineComponent.OutlineColor = Color.red;
                outlineComponent.enabled = true;
                
                if (Input.GetMouseButtonDown(0))
                {
                    if(hidden == false)
                    {
                       /* GameObject.Find("Hero").GetComponentInChildren<CapsuleCollider>().enabled = false;
                        GameObject.Find("Hero").GetComponent<PlayerMovement>().enabled = false;
                        hidden = true;
                        Debug.Log("Itworks");*/
                    }
                    
                    
                }

                _selection = selection;              
            }
                   
        }

    }
}
