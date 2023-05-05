using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatmapConfig : MonoBehaviour
{
    public Toggle Diff;

    public Toggle Ext;

    void start() {
        if(PlayerPrefs.GetInt("difficulty") == 0) {
            Diff.isOn = false;
        }
        else {
            Diff.isOn = true;
        }
        if(PlayerPrefs.GetInt("extended") == 0) {
            Ext.isOn = false;
        }
        else {
            Ext.isOn = true;
        }
    }
    public void Difficulty() {
        if(PlayerPrefs.GetInt("difficulty") == 0) {
            PlayerPrefs.SetInt("difficulty", 1);
            print(PlayerPrefs.GetInt("difficulty"));
        }
        else {
            PlayerPrefs.SetInt("difficulty", 0);
            print(PlayerPrefs.GetInt("difficulty"));
        }
    }

    public void Extended() {
        if(PlayerPrefs.GetInt("extended") == 0) {
            PlayerPrefs.SetInt("extended", 1);
        }
        else {
            PlayerPrefs.SetInt("extended", 0);
        }
    }
}
