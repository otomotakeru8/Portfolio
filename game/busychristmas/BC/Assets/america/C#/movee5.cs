using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movee5 : MonoBehaviour
{
    // Start is called before the first frame update
   
    int counter = 0;
    float move = 0.02f;

    void Update()
    {
        Vector3 p = new Vector3(move, 0, 0);
        transform.Translate(p);
        counter++;

        //countが100になれば-1を掛けて逆方向に動かす
        if (counter == 200)
        {
            counter = 0;
            move *= -1;
        }
    }
}
