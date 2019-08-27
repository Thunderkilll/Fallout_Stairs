using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {
    public GameObject MainMenu;
    public GameObject Gameover;
    public GameObject ScoreUi;
    public static load instance;
    private void Awake()
    {
        MainMenu.SetActive(true);
        Time.timeScale = 0;

    }
    void Start () {
        instance = this;

    }
    public void replay()
    {
        SceneManager.LoadScene(1);
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	public void play () {
        gameObject.SetActive(false);
        ScoreUi.SetActive(true);
        Time.timeScale = 1;
        
	}
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
        AppHelper.Quit();
    }

    public void GameOver()
    {
        Gameover.SetActive(true);
    }
}
