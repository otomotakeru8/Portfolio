using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test 
{
    public class TestPlayerMath
    {
        
        public Quaternion Lookdirection(float holizontal,float vertical,Quaternion rotation){
            Quaternion look;
            float rad = Mathf.Atan2(vertical * -1,holizontal);
            float degree = rad * Mathf.Rad2Deg;
            float transdegree = degree + 90;
            if (transdegree < -180.0) transdegree = transdegree + 360;
            look = Quaternion.RotateTowards(rotation,Quaternion.Euler(0,transdegree,0),(480*Time.deltaTime));
            return look;
        }
    }
}