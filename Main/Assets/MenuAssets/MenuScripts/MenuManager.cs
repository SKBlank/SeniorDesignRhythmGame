using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] private GameObject LoadingScreen;
    [SerializeField] private GameObject MainMenu;

    [Header("Slider")]
    [SerializeField] private Slider AsyncLoadSlider;

    //starts running the async operation
    public void LoadLevelButton(string levelLoaded) {
        MainMenu.SetActive(false);
        LoadingScreen.SetActive(true);

        StartCoroutine(LoadLevelAsync(levelLoaded));
    }

    IEnumerator LoadLevelAsync(string levelLoaded) {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelLoaded);
        
        while (!loadOperation.isDone) {
            float progress = Mathf.Clamp01(loadOperation.progress / 0.9f);
            AsyncLoadSlider.value = progress;
            yield return null;
        }
    }
    //loads asteroid scene
    public void StartGameAsteroid() {
        SceneManager.LoadScene(FirstRunScript.Globals.AsteroidScene);
    }
    //loads Arrow scene
    public void StartGameRhythm() {
        SceneManager.LoadScene(FirstRunScript.Globals.RhythmScene);
    }

    //exits game
    public void ExitGame() {
        Application.Quit();
    }
}
