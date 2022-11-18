using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2 : MonoBehaviour
{
    private Camera Cam;
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        Cam=Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition=Cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y=0;
        transform.up=mousePosition;

    }
}
