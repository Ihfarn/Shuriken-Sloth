using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {
    // public GameObject CanvasOptions;
    //public GameObject CanvasMainMenu;
    public Canvas CanvasOptions;
    public Canvas CanvasMainMenu;

    public Toggle testqntl;

    private void Start()
    {
        //CanvasOptions.SetActive(false);
        CanvasOptions.gameObject.SetActive(false);

        //CanvasMainMenu.SetActive(true);
        CanvasMainMenu.gameObject.SetActive(true);
        
    }
    public void PindahScene (string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
    }

    public void Options()
    {
        // CanvasOptions.SetActive(true);
        CanvasOptions.gameObject.SetActive(true);
        //CanvasMainMenu.SetActive(false);
        CanvasMainMenu.gameObject.SetActive(false);
    }
    public void KeluarAja() {
        Application.Quit();
    }
  
}
