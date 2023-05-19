using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyScript : MonoBehaviour
{
    public float xStartPos = 0f;
    public int Health;
    public int PathLenght = 10;
    public float moveSpeed = 1;
    void Start()
    {
        xStartPos = gameObject.transform.position.x;
    }
    void Update()
    {
        //Уничтожение мумии
        if(Health == 0)
        {
            PlayerStats.Score += 50;
            Destroy(gameObject);
        }
        //Передвижение мумии
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //Разворот
        if(gameObject.transform.position.x < xStartPos || gameObject.transform.position.x > (xStartPos + PathLenght))
        {      
            moveSpeed *= -1;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Health -= 1;
        }
    }
}
