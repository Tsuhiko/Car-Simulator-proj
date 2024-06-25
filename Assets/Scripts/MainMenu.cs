using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;

    void Start()
    {
        mainMenuUI.SetActive(true);
    }

    public void StartGamePressed()
    {
        mainMenuUI.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGamePressed()
    {
        Application.Quit();
    }

    void Update()
    {

    }
}
