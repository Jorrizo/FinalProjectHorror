using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingRaycast : MonoBehaviour
{
    
    Ray ray;
    RaycastHit hit;

    public int RaySize = 10;

    private Transform _selection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(_selection != null)
        {
            _selection.GetComponent<Outline>().enabled = false;
            _selection = null;
        }

        if (Physics.Raycast(ray, out hit, RaySize))
        {
            var selection = hit.transform;
            Debug.DrawLine(ray.origin, hit.point);

            if (selection.CompareTag("Interactive"))
            {
                hit.collider.gameObject.GetComponent<Outline>().enabled = true;                

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("Itworks");
                }

                _selection = selection;              
            }
            
       
        }


    }
}
