using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public double ShootDelay;
    public double Timer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > ShootDelay)
        {
            BulletScritp.xOff = 0;
            BulletScritp.yOff = 0;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Instantiate(bullet, firePoint.position, Quaternion.identity);
                Timer = 0;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Instantiate(bullet, firePoint.position, Quaternion.identity);
                Timer = 0;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                if (GetComponent<MoveScript>().direc == -1)
                {
                    Vector3 theScale = transform.localScale;
                    theScale.x *= -1;
                    transform.localScale = theScale;
                    GetComponent<MoveScript>().direc = -GetComponent<MoveScript>().direc;
                }
                Instantiate(bullet, firePoint.position, Quaternion.identity);
                Timer = 0;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (GetComponent<MoveScript>().direc == 1)
                {
                    Vector3 theScale = transform.localScale;
                    theScale.x *= -1;
                    transform.localScale = theScale;
                    GetComponent<MoveScript>().direc = -GetComponent<MoveScript>().direc;
                }
                Instantiate(bullet, firePoint.position, Quaternion.identity);
                Timer = 0;
            }
            //Нормализация вертикального положения
            Vector3 grad = transform.eulerAngles;
            grad.z = 0;
            transform.rotation = Quaternion.Euler(grad);
        }
    }  
}
