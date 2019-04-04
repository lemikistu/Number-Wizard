using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    /* this function loads next scene 
     * by getting current scene using scene manager's active scene function
     * and setting scene to next scene using scene manager's load scene function */
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // this function load first scene and used for restart button
    public void LoadStartScene()
    {

        SceneManager.LoadScene(0);
    }

    // used for quit button,quits the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
