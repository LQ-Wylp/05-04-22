using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadScene(string NameScene)
    {
        SceneManager.LoadScene(NameScene);
    }

    public void LoadSceneAdditive(string NameScene)
    {
         SceneManager.LoadScene(NameScene, LoadSceneMode.Additive);
    }

    public void UnloadScene(string NameScene)
    {
        SceneManager.UnloadSceneAsync(NameScene);
    }
}
