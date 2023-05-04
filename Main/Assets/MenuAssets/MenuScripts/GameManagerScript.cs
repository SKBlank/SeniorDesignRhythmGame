using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public PauseController Pauser;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void gameOver() {
        Pauser.TogglePause();
        gameOverScreen.SetActive(true);
    }
}
