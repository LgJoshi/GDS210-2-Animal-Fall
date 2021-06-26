using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFall : MonoBehaviour
{
    bool falling =false;

    void OnEnable(){
        EventManager.PhaseChanged +=StartFall;
        EventManager.GameEnded += EndFall;
    }

    void OnDisable(){
        EventManager.PhaseChanged-=StartFall;
        EventManager.GameEnded -= EndFall;
    }

    // Update is called once per frame
    void Update()
    {
        if (falling){
            this.transform.position += new Vector3(0,-1f*Time.deltaTime,0);
        }
    }

    void StartFall(){
        falling=true;
    }

    void EndFall(){
        falling=false;
    }
}
