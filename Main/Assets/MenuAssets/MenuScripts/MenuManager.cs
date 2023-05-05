using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class MenuManager : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject LoadingScreen;
    [SerializeField] private GameObject OptionsMenu;

    [Header("Slider")]
    [SerializeField] private Slider AsyncLoadSlider;

    [Header("VideoToggle")]
    [SerializeField] private VideoPlayer VPlayer;

    [Header("Snore")]

    public float snore;

    private float timeElapsed;
    void Start()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }



    //starts running the async operation
    public void LoadLevelButton(string levelLoaded) {
        //LoadingScreen.SetActive(true);
        //MainMenu.SetActive(false);
        

        StartCoroutine(LoadLevelAsync(levelLoaded));
    }

    IEnumerator LoadLevelAsync(string levelLoaded) {
        if(levelLoaded != "MainMenu") {
            MainMenu.SetActive(false);
        }

        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelLoaded);
        loadOperation.allowSceneActivation = false;
        
        while (!loadOperation.isDone) {
            timeElapsed += Time.deltaTime;
            
            float progress = Mathf.Clamp01(loadOperation.progress / 0.9f);
            AsyncLoadSlider.value = progress;

            if(loadOperation.progress >= 0.9f && timeElapsed >= snore) {
                VPlayer.Pause();
                loadOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    /*IEnumerator GoToSleep() {
        yield return new WaitForSeconds(snore);
        Debug.Log("Wake up!");
    }*/
    //loads asteroid scene
    /*public void StartGameAsteroid() {
        SceneManager.LoadScene(FirstRunScript.Globals.AsteroidScene);
    }
    //loads Arrow scene
    public void StartGameRhythm() {
        SceneManager.LoadScene(FirstRunScript.Globals.NewArrowScene);
    }*/

    //exits game
    public void ExitGame() {
        Application.Quit();
    }
}
