using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//namespace of scene management
using UnityEngine.SceneManagement;

//pengelolaan scene bisa terbaca berdasarkan index di
// file -> build setting



public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        //current scene index   class        method           property
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //nanti di buildIndex mencari scene dalam array
        //load next scene
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
