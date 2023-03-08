using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGameAsteroid() {
        SceneManager.LoadScene(FirstRunScript.Globals.AsteroidScene);
    }
    
    public void StartGameRhythm() {
        SceneManager.LoadScene(FirstRunScript.Globals.RhythmScene);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
