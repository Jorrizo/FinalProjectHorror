using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
    public class FPC : MonoBehaviour
    {

    private Rigidbody rig;
    public int speed = 10;

        // Use this for initialization
        private void Start()
        {
        rig.GetComponent<Rigidbody>();
        }


        // Update is called once per frame
        private void Update()
        {
        float mouveHorizontal = Input.GetAxis("Horizontal");
        float mouveVertical = Input.GetAxis("Vertical");

        Vector3 mouvment = new Vector3(mouveHorizontal, 0, mouveVertical);
        rig.AddForce(mouvment * speed * Time.deltaTime);
    }

}

