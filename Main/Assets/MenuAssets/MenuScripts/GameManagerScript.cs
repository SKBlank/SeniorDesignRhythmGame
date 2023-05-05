using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public PauseController Pauser;

    public RestartController Restarter;

    public void GameOver() {
        Pauser.TogglePause();
        gameOverScreen.SetActive(true);
    }

    public void RestartGame() {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
    }
}
