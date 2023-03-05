using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moji : MonoBehaviour
{
    //invokeの処理が終わったかの判定
    bool inv = true;
    int j = 0;
    //ループ時間調整
    [SerializeField] Animator N;
    [SerializeField] Animator O;
    [SerializeField] Animator W;
    [SerializeField] Animator L;
    [SerializeField] Animator o;
    [SerializeField] Animator a;
    [SerializeField] Animator d;
    [SerializeField] Animator i;
    [SerializeField] Animator n;
    [SerializeField] Animator g;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Now", 0.25f, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Now()
    {
        Debug.Log(j);
        j++;
        switch (j)
        {
            case 1:
                N.SetBool("Bool", true);
                O.SetBool("Bool", false);
                break;
            case 2:
                O.SetBool("Bool", true);
                W.SetBool("Bool", false);
                break;
            case 3:
                W.SetBool("Bool", true);
                L.SetBool("Bool", false);
                break;
            case 4:
                L.SetBool("Bool", true);
                o.SetBool("Bool", false);
                break;
            case 5:
                o.SetBool("Bool", true);
                a.SetBool("Bool", false);
                break;
            case 6:
                a.SetBool("Bool", true);
                d.SetBool("Bool", false);
                break;
            case 7:
                d.SetBool("Bool", true);
                i.SetBool("Bool", false);
                break;
            case 8:
                i.SetBool("Bool", true);
                n.SetBool("Bool", false);
                break;
            case 9:
                n.SetBool("Bool", true);
                g.SetBool("Bool", false);
                break;
            case 10:
                g.SetBool("Bool", true);
                N.SetBool("Bool", false);
                j =0;
                break;
        }
    }
}
