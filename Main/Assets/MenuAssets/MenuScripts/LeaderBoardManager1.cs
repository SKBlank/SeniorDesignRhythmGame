using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class LeaderBoardManager1 : MonoBehaviour
{
   public string[] playerNames = new string[10];
    public int[] scores = new int[10];

    public 

    void Start()
    {
        for (int i = 0; i < 10; i++) {
            playerNames[i] = PlayerPrefs.GetString("PlayerName" + i, "");
            scores[i] = PlayerPrefs.GetInt("Score" + i, 0);
        }
        SortScores();
    }

    void SortScores() {
        string temp;
        int tempscore;
        for (int i = 0; i < 10; i++) {
            for(int k = i+1; k < 10; k++) {
                if(scores[i] < scores[k]) {
                    tempscore = scores[i];
                    temp = playerNames[i];

                    scores[i] = scores[k];
                    playerNames[i] = playerNames[k];

                    scores[k] = tempscore;
                    playerNames[k] = temp;
                }
            }
        }
    }

    public int TestEntry() {
        int winnerindex = -1;
        for(int i = 0; i < 10; i++) {
            if(scores[i] < PlayerPrefs.GetInt("NewcomerScore")) {
                scores[i] = PlayerPrefs.GetInt("NewcomerScore");
                playerNames[i] = PlayerPrefs.GetString("Newcomer");
                winnerindex = i;
            }
        }
        UpdateEntries();
        return winnerindex;
    }

    void UpdateEntries() {
        for (int i = 0; i < 10; i++) {
            PlayerPrefs.SetInt("Score"+ i, scores[i]);
            PlayerPrefs.SetString("PlayerName" + i, playerNames[i]);
        }
    }

    void Display(int winnerindex) {

    }
}
