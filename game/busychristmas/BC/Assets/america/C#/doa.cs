using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doa : MonoBehaviour
{
    int i;
    bool flag;
    public int re;
    double cuntup;
    // Start is called before the first frame update
    void Start()
    {
        flag=true;
        cuntup=0;
        i=1;
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 1)
        { 
        cuntup+=Time.deltaTime;
        }
            if (cuntup >= 2)
                  { 
            Debug.Log(cuntup);
            cuntup=0;
            i=0;
            Invoke("FF",2f);
            if (flag == true)
                flag=false;
            else if(flag == false)
                flag=true;
            }


        if (flag == true&&i>0)
        {
            this.gameObject.transform.Translate(re*0.002f, 0,0);
        }
        if (flag == false&&i>0)
        {
            this.gameObject.transform.Translate(re*-0.002f, 0,0);
        }
    }
    void FF()
    {
        i=1;
    }
}
