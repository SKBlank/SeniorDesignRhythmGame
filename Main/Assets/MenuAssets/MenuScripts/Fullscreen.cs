using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    public void fullScreen(bool is_fullscreen) {
        Screen.fullScreen = is_fullscreen;
        print("Fullscreen toggled");
    }
}
