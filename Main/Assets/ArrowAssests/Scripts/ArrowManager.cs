using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowManager : MonoBehaviour
{
    int key;
    Dictionary<int, GameObject> im_off;
    Dictionary<int, GameObject> im_on;
    [SerializeField] float SwitchDelay = 4.5f;
    [SerializeField] float PressTime = 2.0f;

    Text pointsText;
    int points;

    bool activated = false;
    bool gotten = false;

    Dictionary<int, KeyCode> keyToKeyCode;

    // Start is called before the first frame update
    void Start(){
        keyToKeyCode = new Dictionary<int, KeyCode>(){
            {2, KeyCode.K},
            {1, KeyCode.U},
            {0, KeyCode.H},
            {4, KeyCode.N},
            {3, KeyCode.M},
        };

        pointsText = GameObject.Find("Points").GetComponent<Text>();

        setArrow();
        Invoke(nameof(turnOnArrow), SwitchDelay);
        Invoke(nameof(turnOffArrow), SwitchDelay+PressTime);
    }

    void Update(){
        if(im_on[key].activeSelf && !gotten){
            activated = true;
            if(Input.GetKeyDown(keyToKeyCode[key])){
                gainPoint();
                gotten = true;
            }
        }

        if(!im_on[key].activeSelf && activated && !gotten){
            losePoint();
            gotten = true;
        }
    }

    void gainPoint(){
        //Debug.Log("WOOHOO");
        points = pointsText.text[pointsText.text.Length -1] - '0';
        points++;
        pointsText.text = "Points: "+points;
    }

    void losePoint(){
        points = pointsText.text[pointsText.text.Length -1] - '0';
        if(points > 0) points--;
        pointsText.text = "Points: "+points;
    }

    void setArrow(){
        im_off = new Dictionary<int, GameObject>(){
            {0, transform.GetChild(0).gameObject},
            {1, transform.GetChild(1).gameObject},
            {2, transform.GetChild(2).gameObject},
            {3, transform.GetChild(3).gameObject},
            {4, transform.GetChild(4).gameObject},
        };

        for(int i=0; i<5; i++) im_off[i].SetActive(false);

        im_on = new Dictionary<int, GameObject>(){
            {0, transform.GetChild(5).gameObject},
            {1, transform.GetChild(6).gameObject},
            {2, transform.GetChild(7).gameObject},
            {3, transform.GetChild(8).gameObject},
            {4, transform.GetChild(9).gameObject},
        };

        for(int i=0; i<5; i++) im_on[i].SetActive(false);

        key = Random.Range(0,5);
        im_off[key].SetActive(true);
    }

    void turnOnArrow(){
        im_off[key].SetActive(false);
        im_on[key].SetActive(true);
    }

    void turnOffArrow(){
        im_on[key].SetActive(false);
        im_off[key].SetActive(true);
    }
}
