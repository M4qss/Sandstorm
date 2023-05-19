using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public int direc = 1;
    public Animator anim;
    public Text tbScore;
    void Start()
    {
        
    }
    void Update()
    {
        tbScore.text = Convert.ToString(PlayerStats.Score);
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            //rotate
            if (direc == -1)
            {
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                direc = -direc;
            }
            anim.SetTrigger("moveTrig");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            //rotate
            if(direc == 1)
            {
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                direc = -direc;
            }
            anim.SetTrigger("moveTrig");
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            anim.SetTrigger("moveTrig");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
            anim.SetTrigger("moveTrig");
        }
        //Анимация стрельбы
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetTrigger("shootTrig");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetTrigger("shootTrig");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetTrigger("shootTrig");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetTrigger("shootTrig");
        }
    }
}
