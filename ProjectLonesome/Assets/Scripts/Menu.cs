using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject PauseMenu;
    bool paused = false;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            paused = togglePause();
        }
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
            return (true);
        }
    }


    public void StartGame()
    {
        // paused = togglePause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToMenu()
    {
        paused = togglePause();
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        // paused = togglePause();
        Debug.Log("Quit game.");
        Application.Quit();
    }
}
