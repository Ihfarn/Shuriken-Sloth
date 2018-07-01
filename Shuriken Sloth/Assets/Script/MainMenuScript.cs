using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {
  

    public Canvas CanvasMainMenu;

    public Toggle testToggle;

    private void Start()
    {
      
        CanvasMainMenu.gameObject.SetActive(true);
        
    }
    public void PindahScene (string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
    }

    public void Options()
    {
        // CanvasOptions.SetActive(true);
      
        //CanvasMainMenu.SetActive(false);
        CanvasMainMenu.gameObject.SetActive(false);
    }
    public void KeluarAja() {
        Application.Quit();
    }
  
}
