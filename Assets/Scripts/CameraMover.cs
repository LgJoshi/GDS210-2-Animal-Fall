using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    Transform myTransform;

    void Awake()
    {
        myTransform=this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") !=0 ) {
            myTransform.position += new Vector3(0, Input.GetAxis("Mouse ScrollWheel")*5, 0);
        }
    }
}
