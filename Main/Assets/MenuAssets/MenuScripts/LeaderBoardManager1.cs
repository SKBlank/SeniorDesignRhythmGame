using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class LeaderBoardManager1 : MonoBehaviour
{
   public string[] playerNames = new string[10];
    public int[] scores = new int[10]; 
    public Canvas scoreboard;

    void Start()
    {
        //populate player prefs with dummy values 
        // for (int i = 0; i < 10; i++) {
        //     PlayerPrefs.SetString("PlayerName" + i, "Player" + i);
        //     PlayerPrefs.SetInt("Score" + i, 100 - i * 10);
        // }

        for (int i = 0; i < 10; i++) {
            playerNames[i] = PlayerPrefs.GetString("PlayerName" + i, "");
            scores[i] = PlayerPrefs.GetInt("Score" + i, 0);
        }
        SortScores();
        Display();
    }

    void SortScores() {
        string temp;
        int tempscore;
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 9 - i; j++) {
                if (scores[j] < scores[j + 1]) {
                    tempscore = scores[j];
                    scores[j] = scores[j + 1];
                    scores[j + 1] = tempscore;

                    temp = playerNames[j];
                    playerNames[j] = playerNames[j + 1];
                    playerNames[j + 1] = temp;
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

    void Display() {
        for (int i = 0; i < 10; i++)
        {
            scoreboard.transform.GetChild(i).GetChild(1).GetComponent<TextMeshProUGUI>().text = playerNames[i];
            scoreboard.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = scores[i].ToString();
        }
    }
}
