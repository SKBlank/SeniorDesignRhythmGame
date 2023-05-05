using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public void BacktoMenu() {
        SceneManager.LoadScene(FirstRunScript.Globals.MenuScene);
    }
}
