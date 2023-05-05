using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class MenuManagerAsteroid : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject LoadingScreen;
    [SerializeField] VideoPlayer VPlayer;

    [SerializeField] private Slider AsyncLoadSlider;

    private float snore;

    private float timeElapsed;
    void Start()
    {
        PauseMenu.SetActive(false);
        VPlayer.Play();
    }

    public void LoadLevelButton(string levelLoaded) {
        //LoadingScreen.SetActive(true);
        //MainMenu.SetActive(false);
        
        Debug.Log("buttonpressed");
        StartCoroutine(LoadLevelAsync(levelLoaded));
    }

    IEnumerator LoadLevelAsync(string levelLoaded) {

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


}
