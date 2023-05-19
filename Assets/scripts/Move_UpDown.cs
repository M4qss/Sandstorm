using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move_UpDown : MonoBehaviour
{
    public int xUp;
    public float timeM;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime* timeM;
        if (Math.Sin(timer) > 0)
        {
            transform.position += Vector3.up * xUp * Time.deltaTime * (float)Math.Sin(timer);
        }
        else
        {
            transform.position += Vector3.down * xUp * Time.deltaTime * Math.Abs((float)Math.Sin(timer));
        }
    }
}
