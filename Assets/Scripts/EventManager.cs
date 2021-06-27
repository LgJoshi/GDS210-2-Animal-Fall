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
    
    public delegate void GameOver();
    public static event GameOver GameEnded;
    static public void GameEndEvent(){
        GameEnded();
    }

    public delegate void GameWin();
    public static event GameWin GameWon;
    static public void GameWinEvent(){
        GameWon();
    }
}
