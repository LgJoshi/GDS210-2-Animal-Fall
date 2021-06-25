using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void PhaseChange();
    public static event PhaseChange PhaseChanged;

    static public void PhaseChangeEvent(){
        PhaseChanged();
    }

    /*
    public delegate void GameOver();
    public static event GameEnd GameEnded;

    static public void GameEndEvent(){
        GameEnded();
    }
    */
}
