using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject GameOverScreen;
    public PauseController Pauser;

    public LeaderBoardManager1 Leaderboard;

    public RestartController Restarter;

    public void GameOver(int score) {
        if(PauseController.isPaused) {
            Pauser.TogglePause();
        }
        //playerScore 
        GameOverScreen.SetActive(true);
        PlayerPrefs.SetInt("NewcomerScore", score);
        //Leaderboard.Display(Leaderboard.TestEntry());
    }

    public void RestartGame() {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
    }
}
