using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDoorScript : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = transform.parent.GetComponent<Animator>();
    }
    public void BoxAnimation(int playernumber)
    {
        animator.SetBool("Open", true);
        Invoke("Close", 0.25f);
        if (playernumber == 1)
        {
            FindObjectOfType<PlayerDirector>().GetItem(transform.parent.parent.name,1);
        }
        if (playernumber == 2)
        {
            FindObjectOfType<PlayerDirector>().GetItem(transform.parent.parent.name,2);
        }
    }
    void Close()
    {
        animator.SetBool("Open", false);
    }

}
