using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayerVSBot()
    {
        SceneManager.LoadScene("PlayervsBot");
    }

    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }


}
