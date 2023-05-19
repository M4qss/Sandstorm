using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Health = 5;
    static public int Score;
    public float GodInterval = 1;
    private float Timer = 1;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Score = -50;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        //Смерть
        if(Health == 0)
        {
            anim.SetTrigger("deathTrig");
            ((MoveScript)gameObject.GetComponent<MoveScript>()).enabled = false;
            ((ShootScript)gameObject.GetComponent<ShootScript>()).enabled = false;
            anim.SetBool("isDead", true);
            if(PlayerPrefs.GetInt("score") < Score)
            {
                PlayerPrefs.SetInt("score", Score);
            }
            Invoke("SkipToMenu", 2.2f);
        }
    }
    void SkipToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    //Столкновение с монстром
    void OnTriggerStay2D(Collider2D other)
    {
        if (Timer > 1)
        {
            if (other.gameObject.tag == "Monster" || other.gameObject.tag == "Trap")
            {
                Health -= 1;
                Timer = 0;
            }
        }
    }
}
