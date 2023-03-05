using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Doorway : MonoBehaviour
{


    [SerializeField]public float size;
    GameObject right;
    GameObject left;
    GameObject up;
    GameObject carpet;
    BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        right = transform.Find("DoorCubeRight").gameObject;
        left = transform.Find("DoorCubeLeft").gameObject;
        up = transform.Find("DoorCubeUp").gameObject;
        carpet = transform.Find("Carpet").gameObject;
        collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("大きさリセット")]
    void Sizereset()
    {
        size = 1;
        right.transform.localPosition = new Vector3(0.7f,1f,0f);
        right.transform.localScale = new Vector3(0.2f,2f,0.2f);
        left.transform.localPosition = new Vector3(-0.7f, 1f, 0f);
        left.transform.localScale = new Vector3(0.2f, 2f, 0.2f);
        up.transform.localPosition = new Vector3(0f, 1.9f, 0f);
        up.transform.localScale = new Vector3(1.2f, 0.2f, 0.2f);
        carpet.transform.localPosition = new Vector3(0f, 0.05f, -0.6f);
        carpet.transform.localScale = new Vector3(0.15f, 1f, 0.1f);
        collider.size = new Vector3(1.2f, 1.8f, 0.2f);
    }

    [HideInInspector]public GameObject gitem = null;
    private void OnCollisionEnter(Collision collision)
    {
        gitem = collision.gameObject;
        GameObject.FindObjectOfType<resipi>().Getitem(gitem);
        gitem = null;
        Destroy(collision.gameObject);
        GameObject p1 = GameObject.Find("Player1");
        GameObject p2 = GameObject.Find("Player2");
        float p1d = Vector3.Distance(transform.position,p1.transform.position);
        float p2d = Vector3.Distance(transform.position,p2.transform.position);
        if (p1d < p2d)
        {
            GameObject p1hi = FindObjectOfType<PlayerDirector>().Itemcheck();
            if (collision.gameObject.name == p1hi.name)
            {

            }
        }
    }
}
