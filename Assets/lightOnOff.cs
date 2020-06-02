using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOnOff : MonoBehaviour
{
    public Light myLight;        // Your light

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        flash();
    }

    public void flash()
    {
        if(myLight.intensity <= 4)
        {
            myLight.intensity += 1 * Time.deltaTime;
        }

        if(myLight.intensity >= 7)
        {
            myLight.intensity -= 1 * Time.deltaTime;
        }
    }
}
