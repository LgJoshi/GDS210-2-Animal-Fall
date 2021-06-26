using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform animalTrans;

    // Start is called before the first frame update
    void Start()
    {
        animalTrans = GameObject.Find("Animal").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(animalTrans.position.x, animalTrans.position.y, this.transform.position.z);
    }
}
