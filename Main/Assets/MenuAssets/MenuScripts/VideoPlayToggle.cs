using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class VideoPlayToggle : MonoBehaviour
{
    [SerializeField] VideoPlayer VPlayer;
    // Start is called before the first frame update

    public void TogglePlay() {
        if(VPlayer.isPlaying == false) {
            VPlayer.Play();
        }
        else {
            VPlayer.Pause();
        }
    }
}
