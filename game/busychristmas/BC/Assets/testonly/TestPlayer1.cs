using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Test;

namespace Test
{
    public class TestPlayer1 : MonoBehaviour
    {
        
        public void spawn(Vector3 position){
            transform.position = position;
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        public void look(Quaternion direction){
            transform.rotation = direction;
        }
        public void Move(float speed,float dash){
            Vector3 forward = transform.forward;
            GetComponent<Rigidbody>().velocity = forward * speed * dash;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "deth")
            {
                FindObjectOfType<TestPlayer>().Checkdeth(1);
                //Destroy(gameObject);
            } 
        }

        private void OnTriggerStay(Collider other)
        {
            if(other.gameObject.tag == "Item")
            {

            }
            if (other.gameObject.tag == "Box")
            {

            }
            if (other.gameObject.tag == "CraftTable")
            {

            }
            if (other.gameObject.tag == "WrappingTable")
            {

            }
            if (other.gameObject.tag == "BookTable")
            {

            }
            if (other.gameObject.tag == "CakeTable")
            {

            }
            if (other.gameObject.tag == "PCTable")
            {

            }
            if (other.gameObject.tag == "SewingmachineTable")
            {

            }
        }
    }
}

