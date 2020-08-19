using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            AbandonButton();
        }
    }

    // Go to Prologue
    public void AdventureButton()
    {
        SceneManager.LoadScene(1);   
    }

    public void ContinueButton()
    {
        //Load save data
    }

    public void AbandonButton()
    {
        //Exit Game
        Debug.Log("Quit");
        Application.Quit();
    }
}


