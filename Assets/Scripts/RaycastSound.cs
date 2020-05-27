using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSound : MonoBehaviour
{

    public GameObject objet1;
    public GameObject objet2;

    public AudioSource sound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = objet2.transform.position - transform.position;
        
        Debug.DrawRay(transform.position, direction, Color.red);
        RaycastHit hit;
        Ray ray = new Ray(objet2.transform.position, direction);

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "Wall")
            {
                sound.volume = 0.003f;
            }
            else
            {
                sound.volume = 0.2f;
            }
        }
    }
}
