﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;
    public float boundx = 0.3f;
    public float boundy = 0.15f;

    private void LateUpdate() {
        Vector3 delta = Vector3.zero;
        float deltaX = lookAt.position.x - transform.position.x;
        // if outside the box
        if(deltaX > boundx || deltaX < -boundx)
        {
            // check whether outside on left
            if(transform.position.x < lookAt.position.x)
            {
                // set delta
                delta.x = deltaX - boundx;
            }
            // or whether outside on right
            else
            {
                delta.x = deltaX + boundx;
            }
        }
        float deltaY = lookAt.position.y - transform.position.y;
        if(deltaY > boundy || deltaY < -boundy)
        {
            if(transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundy;
            }
            else
            {
                delta.y = deltaY + boundy;
            }
        }
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
