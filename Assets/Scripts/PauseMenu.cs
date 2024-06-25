using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseMenuUI.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseMenuUI.SetActive(false);
            }
        }
    }

    public void ContinueGamePressed()
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
    }

    public void BackMainMenuPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGamePressed()
    {
        Application.Quit();
    }
}
