using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    bool isMute;
    public GameObject MuteButtonGO;
    

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        isMute = false;
    }

    public void OnButtonClick()
    {
        if(Time.timeScale > 0)
        {
            gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    public void OnExitPauseMenu()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void MuteButtion()
    {
        if(!isMute)
        {
            AudioListener.volume = 0;
            MuteButtonGO.GetComponent<Image>().color = Color.gray;
            
        }
        else
        {
            AudioListener.volume = 1;
            MuteButtonGO.GetComponent<Image>().color = Color.white;

        }

        
        isMute = !isMute;
    }
}
