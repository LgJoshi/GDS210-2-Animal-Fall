using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    [SerializeField] Camera readyCamera;
    [SerializeField] Camera simulationCamera;

    void OnEnable() {
        EventManager.PhaseChanged += ChangeCamera;
    }
    void OnDisable() {
        EventManager.PhaseChanged -= ChangeCamera;
    }

    void Start()
    {
        readyCamera.enabled = true;
        simulationCamera.enabled = false;
    }

    void Update(){
        if(Input.GetKeyDown("q")){
            EventManager.PhaseChangeEvent();
        }
        if(Input.GetKeyDown("w")){
            EventManager.GameEndEvent();
        }
    }

    void ChangeCamera(){
        Debug.Log("ChangeCamera function");
        readyCamera.enabled = false;
        simulationCamera.enabled = true;
    }
}
