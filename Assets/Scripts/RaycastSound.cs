using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSound : MonoBehaviour
{

    public GameObject monster;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = monster.transform.position - transform.position;
        
        Debug.DrawRay(transform.position, direction, Color.red);
        RaycastHit hit;
        Ray ray = new Ray(transform.position, direction);

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "wall")
            {
                Debug.Log("WOW UN MUR !!");
            }
        }
    }
}
