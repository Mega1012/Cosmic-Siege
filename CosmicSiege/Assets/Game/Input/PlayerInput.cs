using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput 
{

    public Vector2 MovPlayer()
    {
        Vector2 v = new Vector2();
        if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            v.x = 1;
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            v.x = -1;
        }

        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            v.y = 1;
        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            v.y = -1;
        }
        return v;
    }
}
