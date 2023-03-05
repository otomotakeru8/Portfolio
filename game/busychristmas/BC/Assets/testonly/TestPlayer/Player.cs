using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace testonly
{
    public class Player : MonoBehaviour
    {
        Rigidbody rb;
        Vector3 playerposition;
        float inputx;
        float inputy;
        int rotationlock;
        bool move;
        public float speed;
        float dash;
        public bool itemhold;
        //[SerializeField] public GameObject nobject;

        [SerializeField] public GameObject[] needobject;
        [SerializeField] public GameObject[] item;
        float[] od;
        public GameObject nobject;

        bool nhold;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            dash = 1;
            od = new float[needobject.Length];
            itemhold = false;
        }

        // Update is called once per frame
        void Update()
        {
            nhold = itemhold;

            playerposition = this.transform.position;
            if (Input.GetKey(KeyCode.W))
            {
                inputy = 1;
                move = true;
            }
            if (Input.GetKey(KeyCode.S))
            {
                inputy = -1;
                move = true;
            }
            if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false)) inputy = 0;
            if (Input.GetKey(KeyCode.D))
            {
                inputx = 1;
                move = true;
            }
            if (Input.GetKey(KeyCode.A))
            {
                inputx = -1;
                move = true;
            }
            if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false)) inputx = 0;
            if (Input.GetKeyUp(KeyCode.W)) move = false;
            if (Input.GetKeyUp(KeyCode.S)) move = false;
            if (Input.GetKeyUp(KeyCode.D)) move = false;
            if (Input.GetKeyUp(KeyCode.A)) move = false;
            if (inputy == 1)
            {
                if (inputx == 0)
                {
                    rotationlock = 0;
                }
                if (inputx == 1)
                {
                    rotationlock = 45;
                }
                if (inputx == -1)
                {
                    rotationlock = -45;
                }
            }
            if (inputy == 0)
            {
                if (inputx == 1)
                {
                    rotationlock = 90;
                }
                if (inputx == -1)
                {
                    rotationlock = -90;
                }
            }
            if (inputy == -1)
            {
                if (inputx == 0)
                {
                    rotationlock = 180;
                }
                if (inputx == 1)
                {
                    rotationlock = 135;
                }
                if (inputx == -1)
                {
                    rotationlock = -135;
                }
            }
            transform.rotation = Quaternion.Euler(0, rotationlock, 0);
            Vector3 playerforward = transform.forward;
            if (move == true)
            {
                float rbvy = rb.velocity.y;
                rb.velocity = playerforward * speed * dash;
                rb.velocity = new Vector3(rb.velocity.x, rbvy, rb.velocity.z);
            }
            else
            {
                rb.velocity = new Vector3(0, rb.velocity.y, 0);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift)) dash = 2;
            if (Input.GetKeyUp(KeyCode.LeftShift)) dash = 1;
            Data.PlayerPosition = this.transform.position;
            Data.PlayerRotation = this.transform.rotation;

            if (nhold == true)
            {
                if (Input.GetKeyDown(KeyCode.I)) itemhold = false;
            }
            else if (Input.GetKeyDown(KeyCode.I)) itemhold = true;

            /*for (int i = 0;i < needobject.Length; i++){
                od[i] = Mathf.Abs(transform.position.x - needobject[i].transform.position.x) + Mathf.Abs(transform.position.z - needobject[i].transform.position.z);
                if (i == 0) nobject = needobject[i];
                if (i > 0){
                    if (od[i] < od[i-1]) nobject = needobject[i];
                }
                if ((Mathf.Abs(transform.position.x - nobject.transform.position.x) + Mathf.Abs(transform.position.z - nobject.transform.position.z)) > 1.5f) nobject = null;
            }*/
        }

        private void OnTriggerStay(Collider other)
        {
            /*if (other.gameObject.tag == "table")
            {
                Data.needbox = true;
                Data.needboxposition = other.transform.position;
            }
            else Data.needbox = false;*/
            if (other.gameObject.tag == "box")
            {
                if (itemhold == false)
                {
                    if (Input.GetKeyDown(KeyCode.I))
                    {
                        FindObjectOfType<ItemDirector>().TakeItem();
                        itemhold = true;
                    }
                }
            }
            /*if (other.gameObject.tag == "crafttable")
            {
                Data.needcrafttable = true;
                Data.needcrafttableposition = other.transform.position;
            }
            else Data.needcrafttable = false;
            if (other.gameObject.tag == "table" || other.gameObject.tag == "box" || other.gameObject.tag == "crafttable");
            else*/
            if (other.gameObject.tag == "item")
            {
                Data.needitemformplayer = true;
            }
            else Data.needitemformplayer = false;
        }
    }

}