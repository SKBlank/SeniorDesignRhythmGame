using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardManaer : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] playerNames = new string[10];
    public int[] scores = new int[10];
    void Start()
    {
        for (int i = 0; i < 10; i++) {
            playerNames[i] = PlayerPrefs.GetString("PlayerName" + i, "")
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
