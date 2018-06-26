using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
 public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject hpGambar;
    // Update is called once per frame
       void Update()
    {
        Debug.Log(GameIsPaused);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();

            }
        }
    }
   public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        hpGambar.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void PauseGame ()
    {
        pauseMenuUI.SetActive(true);
        hpGambar.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu ()
    {
        SceneManager.LoadScene("Main Menu");
        
    }
}
    
