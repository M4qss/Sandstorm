using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScritp : MonoBehaviour
{
    //Направление для полета пули
    public float moveSpeed = 5;
    public static float xOff = 0;
    public static float yOff = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (yOff == 0 && xOff == 0)
        {
            //Изменение направления
            if (Input.GetKey(KeyCode.UpArrow))
            {
                yOff = 1;
                xOff = 0;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                yOff = -1;
                xOff = 0;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                yOff = 0;
                xOff = 1;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                yOff = 0;
                xOff = -1;
            }
        }
        //Движение по XO
        if (xOff != 0)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime * xOff;
        }
        //Движение по YO
        if (yOff != 0)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime * yOff;
        }
    }
    //Уничтожение объекта при столкновении со стеной
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Solid")
        { 
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Monster")
        {
            Destroy(gameObject);
        }
    }
}