using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadMenu(){
        SceneManager.LoadScene(0);
    }

    public void LoadGame(){
        SceneManager.LoadScene(1);
    }

    public void LoadCredits(){
        SceneManager.LoadScene(2);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
