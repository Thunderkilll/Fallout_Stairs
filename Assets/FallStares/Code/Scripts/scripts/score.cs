using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour {

    public Transform player;
    public Text textscoere;
    public Text yourscoere;
    public Text highScore;
    float i;
    //public ToolTip tools;
    void OnMouseOver()
    {
        Debug.Log("hovering");
    }

    void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
    }
    void Update () {
        i = -player.position.y + 102;
        
        textscoere.text = (i / 5).ToString("0");
        yourscoere.text = textscoere.text;

        if (PlayerPrefs.GetInt("score") <= (int)i/5)
            PlayerPrefs.SetInt("score", (int)i/5);
        highScore.text = PlayerPrefs.GetInt("score").ToString();



    }

}
