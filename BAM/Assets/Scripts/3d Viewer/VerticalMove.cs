﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Security.Cryptography;
using System.Threading;

public class VerticalMove : MonoBehaviour
{
    public float speed;

    void Update()
    {

        // get the user touch inpun
        foreach (Touch touch in Input.touches)
        {
            Debug.Log("Touching at: " + touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch phase began at: " + touch.position);
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Touch phase Moved");
                transform.Rotate(touch.deltaPosition.y * speed * Time.deltaTime, 0, 0);

            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Touch phase Ended");
            }
        }
    }
}
