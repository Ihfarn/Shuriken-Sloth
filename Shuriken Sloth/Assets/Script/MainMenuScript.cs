using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
    public GameObject CanvasOptions;
    public GameObject CanvasMainMenu;
    private void Start()
    {
        CanvasOptions.SetActive(false);
        CanvasMainMenu.SetActive(true);
        
    }
    public void PindahScene (string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
    }
    public void Options()
    {
        CanvasOptions.SetActive(true);
        CanvasMainMenu.SetActive(false);
    }
    public void KeluarAja() {
        Application.Quit();
    }
}
