using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider : MonoBehaviour
{
    
    public float RotateSpeed = 30f;
   

     public Slider slider;
 
     public float maxRotatePos;
     public float maxRotateNeg;
     public float currentRotation;
 
     void Awake()
     {
         //assign slider attributes
         if(maxRotatePos == 0)
         {
             maxRotatePos = 50;
         }
         if(maxRotateNeg == 0)
         {
             maxRotateNeg = -60;
         }
         slider.maxValue = maxRotatePos;
         slider.minValue = maxRotateNeg;
         currentRotation = 0;
 
     }
 
 
     // Update is called once per frame
     void Update () 
     {
         currentRotation = slider.value;
            transform.Rotate(-Vector3.forward * currentRotation * Time.deltaTime);
     }

}
