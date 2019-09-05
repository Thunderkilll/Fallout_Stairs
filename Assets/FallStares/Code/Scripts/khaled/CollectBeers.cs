using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace KhaledGuesmi
{
    public class CollectBeers : MonoBehaviour
    {
        public Text scoreUi;
        int score = 0;
        void Start()
        {
            
            score = PlayerPrefs.GetInt("BeersScore");
            scoreUi.text = score.ToString();
        }
        //on player interraction with the beer cup we will add it to our collection
        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {

                
               // Debug.Log("name : " + beer.name + "\n Description : " + beer.description + "\n Added Score = " + beer.Score);
                
                score = score +1 ;
                PlayerPrefs.SetInt("BeersScore", score);
                scoreUi.text = score.ToString();
                Destroy(gameObject , 0.1f);

            }

        }
    }
}

