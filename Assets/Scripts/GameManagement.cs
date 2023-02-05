using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button restartButton;
    public bool isGameOn = false;

    void Start(){
        playButton = GetComponent<Button>();
        exitButton = GetComponent<Button>();
        restartButton = GetComponent<Button>();
    }
    public void StartGame(){
        SceneManager.LoadScene(1);
        isGameOn = true;
        Debug.Log("cambio de escena");
    }

    public void RestartGame()
    {
        // SceneManager.LoadScene(SceneManager.Load);
        StartGame();
        Debug.Log("cambio de escena");
    }

    public void exitGame(){
        Application.Quit();
    }

    public void GameOver(){
        isGameOn = false;
        SceneManager.LoadScene(2);
        // Debug.Log("gamer over washo");
    }
}
