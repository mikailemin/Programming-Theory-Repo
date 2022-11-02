using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PauseMenu : MonoBehaviour
{
    public  bool GameisPaused = false;
    public GameObject pauseMenuUI;
    public GameObject player;
  
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

   
   public void Resume()
    {
        GameisPaused = false;
        pauseMenuUI.SetActive(false);
       Time.timeScale = 1f;
        
    }
   void Pause()
    {
        GameisPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void save()
    {
        PlayerPrefs.SetFloat("xPosPl", player.transform.position.x);
        PlayerPrefs.SetFloat("yPosPl", player.transform.position.y);
        PlayerPrefs.SetFloat("zPosPl", player.transform.position.z);




    }
    public void Load()
    {
        if (PlayerPrefs.HasKey("yPos"))
        {

            float xP = PlayerPrefs.GetFloat("xPosPl");
            float yP = PlayerPrefs.GetFloat("yPosPl");
            float zP = PlayerPrefs.GetFloat("zPosPl");
            player.transform.position=new Vector3(xP,yP,zP);

           





        }
        else
        {
            Debug.Log("Veri Bulunamadı");
        }
    }

}
