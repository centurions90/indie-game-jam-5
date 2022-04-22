using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] string mainMenuSceneName;
    string lastLevel;

    private void Start()
    {
        lastLevel = mainMenuSceneName;
        setLastLevel(mainMenuSceneName);
    }

    private void setLastLevel(string level)
    {
        lastLevel = level;
    }

    public void OpenScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadLastScene()
    {
        SceneManager.LoadScene(lastLevel);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
