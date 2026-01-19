using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadScene(int idx)
    {
        GameObject sound = GameObject.Find("BackgroundSound");
        if(idx == 0 && sound !=null)
        {
            Destroy(sound);
        }
        SceneManager.LoadScene(idx);
        Time.timeScale = 1;
    }
}

