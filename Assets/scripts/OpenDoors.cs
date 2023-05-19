using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public GameObject[] doors;
    public GameObject[] monsters;
    private bool state = false;
    void Update()
    {
        state = true;
        foreach (GameObject monster in monsters)
        {
            if(monster != null)
            {
                state = false;
            }
        }
        if (state)
        {
            foreach (GameObject door in doors)
            {
                Destroy(door);
            }
        }
    }
}
