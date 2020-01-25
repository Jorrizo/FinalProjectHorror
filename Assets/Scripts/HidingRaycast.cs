using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingRaycast : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.collider.gameObject.CompareTag("Interactive"))
            {
                Debug.Log("Itworks");
            }
        
        }


    }
}
