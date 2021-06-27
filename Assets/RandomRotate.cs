using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       this.transform.rotation=new Quaternion(0,0,Random.Range(-0.12f,0.12f),1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
