using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrans : MonoBehaviour
{
    //Объект камеры
    public Transform cam;
    //Игрок
    public Transform player;
    //Смещение
    public float PlayerXOff;
    public float PlayerYOff;
    public float CamXOff;
    public float CamYOff;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            cam.position = new Vector3(CamXOff, CamYOff, -10);
            player.position = new Vector3(PlayerXOff, PlayerYOff, 0);
        }
    }
}
