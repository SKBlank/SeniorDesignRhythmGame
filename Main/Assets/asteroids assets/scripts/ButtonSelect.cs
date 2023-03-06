using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSelect : MonoBehaviour
{
    // Build Number of scene to start when start button is pressed
    public int SceneSelect;
    
    /*
    public void StartGameRhythm() {
        SceneManager.LoadScene(Whatever_rhythm_is);
    }
    */
    public void StartGameAsteroid() {
        SceneManager.LoadScene(SceneSelect);
    }
    //why not working
}
