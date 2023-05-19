using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            PlayerStats.Score += 100;
            if (PlayerPrefs.GetInt("score") < PlayerStats.Score)
            {
                PlayerPrefs.SetInt("score", PlayerStats.Score);
            }
            SceneManager.LoadScene("Menu");
        }
    }
}
