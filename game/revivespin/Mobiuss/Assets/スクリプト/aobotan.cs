using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aobotan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (ao.i == 1)
        {
            Destroy(gameObject);
        }
     
    }
}
