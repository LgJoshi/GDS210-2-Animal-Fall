using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform animalTrans;
    Canvas canv;

    // Start is called before the first frame update
    void Start()
    {
        animalTrans = GameObject.Find("Animal").GetComponent<Transform>();
        canv=this.GetComponentInChildren<Canvas>();
        canv.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(animalTrans.position.x, animalTrans.position.y, this.transform.position.z);
    }

    void OnEnable() { 
        EventManager.GameEnded += ToggleCanvas;
        EventManager.GameWon += ToggleCanvas;
    }
    void OnDisable() {
        EventManager.GameEnded -= ToggleCanvas;
        EventManager.GameWon -= ToggleCanvas;
    }


    void ToggleCanvas(){
        canv.enabled=true;
    }

}
