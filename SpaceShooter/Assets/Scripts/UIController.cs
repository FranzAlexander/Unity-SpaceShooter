using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public static bool pausedGame;
    public GameObject pauseMenu;

    // Player Stats To Show
    private float health;
    private float energy;

    void Start()
    {
        pausedGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausedGame)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        // Make the pause menu UI inactive.
        pauseMenu.SetActive(false);
        // Setting the speed at which time is going to 1.
        Time.timeScale = 1f;
        pausedGame = false;
    }

    void PauseGame()
    {
        // Make the pause menu UI active.
        pauseMenu.SetActive(true);
        // Setting the speed at which time is going to 0.
        Time.timeScale = 0f;
        pausedGame = true;
    }

    public void QuitGame()
    {
        // Quitting the application.
        Application.Quit();
    }
}
