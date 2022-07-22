using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartMenuHandler : MonoBehaviour
{
    public InputField PlayerNameInput;

    public void OnNameChanged(string name)
    {
        if (DataManager.Instance != null)
        {
            DataManager.Instance.PlayerName = PlayerNameInput.text;
        }
    }

    public void StartGame()
    {
        int mainSceneIndex = 1;
        SceneManager.LoadScene(mainSceneIndex, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
