using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCollision : MonoBehaviour {
    bool stay = false;
    public bool staystill = false;
    public float stayCount = 3;
    public Text clock;
    public Text scoreUi;
    public GameObject cloq;
    int score = 0;
    public Image clok;
    public static ObstacleCollision instanceObstacleCollision;
 

     void Start()
    {
        instanceObstacleCollision = this;
        score = PlayerPrefs.GetInt("BeersScore");
        scoreUi.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
           
            stay = true;
            cloq.SetActive(true);
        }
        if (other.tag == "Collectable")
        {
             
            Beer beer = other.gameObject.GetComponent<Beer>();
            Debug.Log("name : " + beer.name + "\n Description : " + beer.description + "\n Added Score = " + beer.Score);
           

            ToolTip.ShowToolTip_static("name : " + beer.name + "\n Description : " + beer.description + "\n Added Score = " + beer.Score);
            
            score++;
           PlayerPrefs.SetInt("BeersScore",  score);
            scoreUi.text = score.ToString();
            Destroy(other.gameObject, 0.2f);

        }
       
    }
    
  

    void OnTriggerStay(Collider other)
    {
        if (stay)
        {
            staystill = true;
            if (stayCount > 0)
            {
                
                stayCount = stayCount - Time.deltaTime;//fixed ,delta time 
                clock.text = stayCount.ToString("0");
                clok.fillAmount=stayCount/3;

            } 
            else{

                load.instance.GameOver();

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        stay = false;
        stayCount = 3;
        cloq.SetActive(false);
        staystill = false;
        if (other.tag == "Collectable")
        {

           ToolTip.HideToolTip_static();

        }
    }


  

}
