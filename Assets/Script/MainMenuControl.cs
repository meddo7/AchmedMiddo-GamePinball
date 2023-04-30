using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControl : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitButton);
        creditButton.onClick.AddListener(CreditButton);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    private void ExitButton()
    {
        Application.Quit();
    }

    private void CreditButton()
    {
        SceneManager.LoadScene(2);
    }
}
