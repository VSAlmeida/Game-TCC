using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera Switch"))
        {
            cam1.SetActive(!cam1.activeInHierarchy);
            cam2.SetActive(!cam2.activeInHierarchy);
        }
    }
}
