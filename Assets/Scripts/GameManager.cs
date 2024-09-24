using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    #region Unity_functions
    private void Awake() {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    #region Scene_transitions
    public void StartGame()
    {
        /* TODO 7.2: Change the scene when this function is called to the appropriate scene using SceneManager.LoadScene() */
        SceneManager.LoadScene("SampleScene");
    }

    public void LoseGame()
    {
        /* TODO 7.2: Change the scene when this function is called to the appropriate scene using SceneManager.LoadScene() */
        SceneManager.LoadScene("Lose Scene");
    }

    public void NextLevel()
    {
        /* TODO 7.2: Change the scene when this function is called to the appropriate scene using SceneManager.LoadScene() */
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Level 2");
        }
        else
        {
            SceneManager.LoadScene("Win Scene");
        }
    }

    public void MainMenu()
    {
        /* TODO 7.2: Change the scene when this function is called to the appropriate scene using SceneManager.LoadScene() */
        SceneManager.LoadScene("Main Menu");
    }
    #endregion
}
