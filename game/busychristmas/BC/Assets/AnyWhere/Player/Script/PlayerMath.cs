using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMath
{

    public Quaternion Lookdirection(float holizontal, float vertical, Quaternion rotation){
        Quaternion look;
        float rad = Mathf.Atan2(holizontal, vertical);
        float degree = rad * Mathf.Rad2Deg;
        float transdegree = degree;
        if (transdegree < -180.0) transdegree = transdegree + 360;
        look = Quaternion.RotateTowards(rotation, Quaternion.Euler(0, transdegree, 0), (1440 * Time.deltaTime));
        return look;
    }

    public Vector3 WallScanRadar(float angle,float f,float r30,float l30){
        Vector3 returnvectol = new Vector3(0,0,0);
        if (f >= 1.1f){
            float margin = 2.0f - f;
            //m0 = lr0.9 m1.1 = lr1.2  4:1
            if (r30 < (0.9f + (margin / 5)))
            {
                float difference = f - r30;
                //15~70 1.1 59倍
                float indifference = (0.9f +(margin / 5)) - r30;
                float addrotation = angle + 180 +(15 + difference * 59);
                Vector3 addvectol = new Vector3(Mathf.Cos(addrotation),0,Mathf.Sin(addrotation)).normalized;
                returnvectol = new Vector3(addvectol.x * indifference,0,addvectol.z * indifference);
            }
            if (l30 < (0.9f + (margin / 5)))
            {
                float difference = f - l30;
                float indifference = (0.9f + (margin / 5)) - l30;
                float addrotation = angle + 180 + (15 + difference * 59);
                Vector3 addvectol = new Vector3(Mathf.Cos(addrotation),0,Mathf.Sin(addrotation)).normalized;
                returnvectol = new Vector3(addvectol.x * indifference,0,addvectol.z * indifference);
            }
        }
        if (f < 1.1f)
        {
            Vector3 addvectol = new Vector3(Mathf.Cos(angle + 180),0,Mathf.Sin(angle + 180)).normalized;
            returnvectol = new Vector3(addvectol.x * (1.1f - f),0,addvectol.z * (1.1f - f));
        }
        return returnvectol;
    }

    public GameObject FindObject(GameObject[] objects,Vector3 PlayerPosition)
    {
        GameObject nearestobject = null;
        float minDistance = 1.5f;
        for(int i = 0; i < objects.Length;i++)
        {
            float distance = Vector3.Distance(PlayerPosition,objects[i].transform.position);
            if (distance <= minDistance)
            {
                minDistance = distance;
                nearestobject = objects[i];
            }
        }
        return nearestobject;
    }
}
