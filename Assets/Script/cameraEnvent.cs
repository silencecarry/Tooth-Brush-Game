using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraEnvent : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera[] cams;

    public void camMainMove()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;

    }


    public void camOneMove()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
