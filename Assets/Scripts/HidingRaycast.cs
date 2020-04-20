using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingRaycast : MonoBehaviour
{
    
    Ray ray;
    RaycastHit hit;

<<<<<<< HEAD
    public bool hidden;
    public bool isHidden;

    public int raySize = 10;

    private Transform _selection;

    //pas besoin de remplir dans l'inspector
    public GameObject newCamera;


    void Start()
    {
        newCamera.SetActive(false);
        isHidden = false;
        hidden = false;
=======
    public int RaySize = 10;

    private Transform _selection;

    // Start is called before the first frame update
    void Start()
    {
   
>>>>>>> e99ea32f36c7dd1b68f4d3e3d524dcd047f30198
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

            //pour les cachettes
            if (selection.CompareTag("Interactive"))
            {
<<<<<<< HEAD
                outlineComponent.OutlineColor = Color.red;
                outlineComponent.enabled = true;
                newCamera = selection.GetChild(0).gameObject;

                if (Input.GetMouseButtonDown(0))
                {

                    if (hidden == false)
                    {
                        newCamera.SetActive(true);
                        GameObject.Find("Hero").GetComponentInChildren<CapsuleCollider>().enabled = false;
                        GameObject.Find("Hero").GetComponent<PlayerMovement>().enabled = false;
                        hidden = true;
                        Debug.Log("Itworks");
                    }
                    
                    
=======
                hit.collider.gameObject.GetComponent<Outline>().enabled = true;                

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("Itworks");
>>>>>>> e99ea32f36c7dd1b68f4d3e3d524dcd047f30198
                }

                _selection = selection;
            }

            //pour les objectifs
            if (selection.CompareTag("Quest"))
            {
                outlineComponent.OutlineColor = Color.blue;
                outlineComponent.enabled = true;

                if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log("Object Picked Up");
                }

                _selection = selection;
            }
            
       
        }

<<<<<<< HEAD
        //pour sortir des cachettes
        if(hidden == true)
        {
            if(isHidden == false)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    isHidden = true;
                    Debug.Log("yep");
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                {
                    newCamera.SetActive(false);
                    GameObject.Find("Hero").GetComponentInChildren<CapsuleCollider>().enabled = true;
                    GameObject.Find("Hero").GetComponent<PlayerMovement>().enabled = true;
                    isHidden = false;
                    hidden = false;
                    Debug.Log("yepyep");
                }
            }
            
            
        }
=======
>>>>>>> e99ea32f36c7dd1b68f4d3e3d524dcd047f30198

    }
}
