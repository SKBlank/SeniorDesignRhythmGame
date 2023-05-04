using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;


public class PauseController : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenu;
    float previousTimeScaling = 1;
    //public Text pauseLabel;

    public static bool isPaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            TogglePause();
        }
    }

    public void TogglePause() {
        if(Time.timeScale > 0) {
            previousTimeScaling = Time.timeScale;
            Time.timeScale = 0;
            AudioListener.pause = true;
            PauseMenu.SetActive(true);
            //pauseLabel.enabled = true;
        }
        else if(Time.timeScale == 0) {
            Time.timeScale = previousTimeScaling;
            AudioListener.pause = false;
            //pauseLabel.enabled = false;
            PauseMenu.SetActive(false);

            isPaused = false;
        }
    }

}

