using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HidingRaycast : MonoBehaviour
{
    public GameObject player;
    public GameObject playerBody;
    public GameObject flashLight;

    Ray ray;
    RaycastHit hit;

    public bool hidden;
    public bool isHidden;

    public int raySize = 10;

    private Transform _selection;

    //pas besoin de remplir dans l'inspector
    public GameObject newCamera;


    void Start()
    {
        playerBody.GetComponent<MeshRenderer>().enabled = false;
        newCamera.SetActive(false);
        isHidden = false;
        hidden = false;
    }




    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (_selection != null)
        {
            _selection.GetComponent<OutlineHidingSpot>().DeactivateOutline();
            _selection = null;
        }

        if (Physics.Raycast(ray, out hit, raySize))
        {
            var selection = hit.transform;
            var outlineComponent = selection.GetComponent<Outline>();
            Debug.DrawLine(ray.origin, hit.point);

            //pour les cachettes
            if (selection.CompareTag("Interactive"))
            {
                selection.GetComponent<OutlineHidingSpot>().ActivateOutline();
                newCamera = selection.GetChild(0).gameObject;

                if (Input.GetMouseButtonDown(0))
                {
                    
                    if (hidden == false)
                    {
                        newCamera.SetActive(true);
                        playerBody.SetActive(false);
                        flashLight.SetActive(false);
                        player.GetComponent<PlayerMovement>().enabled = false;
                        hidden = true;
                        Debug.Log("Itworks");
                    }


                }

                _selection = selection;
            }

            //pour les objectifs
            if (selection.CompareTag("Quest"))
            {
                selection.GetComponent<OutlineHidingSpot>().ActivateOutline();

                if (Input.GetMouseButtonUp(0))
                {
                    selection.GetComponent<Objectives>().Interact();
                }

                _selection = selection;
            }

        }

        //pour sortir des cachettes
        if (hidden == true)
        {
            if (isHidden == false)
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
                    playerBody.SetActive(true);
                    flashLight.SetActive(true);
                    player.GetComponent<PlayerMovement>().enabled = true;
                    isHidden = false;
                    hidden = false;
                    Debug.Log("yepyep");
                }
            }


        }

    }
}
