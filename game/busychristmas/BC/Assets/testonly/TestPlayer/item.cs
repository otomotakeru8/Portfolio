using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    bool hold;
    public GameObject player;
    public GameObject ipos;
    bool nhold;
    float d;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hold = false;
    }

    // Update is called once per frame
    void Update()
    {
        nhold = hold;
        d = Mathf.Abs(transform.position.x - player.transform.position.x) + Mathf.Abs(transform.position.z - player.transform.position.z);
        if (d < 1.5)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (nhold == true)
                {
                    hold = false;
                    if (Input.GetKey(KeyCode.LeftControl))
                    {
                        Invoke("Toss", 0.1f);
                    }
                }
                if (nhold == false)
                {
                    hold = true;
                }
            }
        }
        if (hold == true)
        {
            transform.position = ipos.transform.position;
            transform.rotation = Data.PlayerRotation;
            rb.velocity = new Vector3(0,0,0);
            rb.isKinematic = true;
        }
        else rb.isKinematic = false;
    }

    public void Toss()
    {
        rb.velocity = transform.forward * 6;
    }
}
