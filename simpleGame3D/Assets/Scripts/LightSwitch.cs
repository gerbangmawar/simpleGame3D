using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light redLight;
    public Light blueLight;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("n")){
            redLight.enabled = true;
            blueLight.enabled = false;
        }
        if (Input.GetKey ("b")){
            redLight.enabled = false;
            blueLight.enabled = true;
        }
    }
}
