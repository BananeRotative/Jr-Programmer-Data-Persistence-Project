using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField playerNameInputField;
    [SerializeField] TextMeshProUGUI bestScoreText;

    private void Start()
    {
        SetBestScore(PersistenceManager.Instance.bestScorerName, PersistenceManager.Instance.bestScore);
    }

    void SetBestScore(string bestScorerName, int bestScore)
    {
        bestScoreText.text = "Best score : " + bestScorerName + " : " + bestScore;
    }

    public void StartGame()
    {
        PersistenceManager.Instance.playerName = playerNameInputField.text;
        SceneManager.LoadScene(1);
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
