using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame_Button()
    {
        Debug.Log("Start");
    }

    public void QuitGame_Button()
    {
        if (!Application.isEditor)
        {
            Application.Quit();
        }
        else
        {
            Debug.Log("Quit");
        }
    }
}
