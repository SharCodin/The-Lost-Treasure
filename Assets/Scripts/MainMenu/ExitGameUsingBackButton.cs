using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameUsingBackButton : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    public void ExitGame()
    {
        Debug.Log("Application closed");
        Application.Quit();
    }
}
