using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play_Click : MonoBehaviour
{
    public Camera mainOne;
    public Camera exitOne;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        mainOne.enabled = true;
        exitOne.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        if (mainOne.enabled)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void ExitApp()
    {
        if (mainOne.enabled)
        {
            mainOne.enabled = false;
            exitOne.enabled = true;
        }
        else
        {
            mainOne.enabled = true;
            exitOne.enabled = false;
        }
    }
    public void FullOut()
    {
        if (exitOne.enabled)
        {
            Application.Quit();
        }
    }
    public void ScoreReload()
    {
        scoreText.text = "BEST SCORE:" + Convert.ToString(PlayerPrefs.GetInt("score"));
    }
}
