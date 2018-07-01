using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public bool GameIsOver = false;
    public GameObject GameOverUI;
    public GameObject GambarHP;

    // Use this for initialization

   public void GameisOver () {
        GameOverUI.SetActive(false);
        GambarHP.SetActive(true);
        Time.timeScale = 1f;
        GameIsOver = false;
	}

    public void GameHasEnded()
    {
        GameOverUI.SetActive(true);
        GambarHP.SetActive(false);
        Time.timeScale = 0f;
        GameIsOver = true;
    }
    // Update is called once per frame
    public void PindahScene(string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    
    }
   
}

