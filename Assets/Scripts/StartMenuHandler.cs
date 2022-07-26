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
    public Text BestScoreText;

    public InputField PlayerNameInput;

    private void Start()
    {
        DataManager.Instance.LoadBestScoreData();

        //bestScoreText.text = string.Format("Best Score : {0} : {1}", DataManager.Instance.BestScorePlayerName, DataManager.Instance.BestScore);
        BestScoreText.text = $"Best Score : {DataManager.Instance.BestScorePlayerName} : {DataManager.Instance.BestScore}";
    }

    public void OnNameChanged()
    {
        if (DataManager.Instance != null)
        {
            DataManager.Instance.CurrentPlayerName = PlayerNameInput.text;
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
