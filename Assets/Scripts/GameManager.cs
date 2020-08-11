using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Score and Complete Level
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;

    // PauseMenu
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        //Debug.Log("Level Win");
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Debug.Log("press Escape");
            if (GameIsPause)
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
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void LoadMenu()
    {
        //Debug.Log("loading scene......");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void QuitGame()
    {
        //Debug.Log("quit game");
        Application.Quit();
    }
}
