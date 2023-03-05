using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Test;

namespace Test
{
    public class TestPlayer : MonoBehaviour
    {
        TestPlayerMath testPlayerMath = new TestPlayerMath();

        [SerializeField]
        float speed;
        float dash1 = 1;
        float dash2 = 1;

        float LStick1Horizontal;
        float LStick1Vertical;
        float LStick2Horizontal;
        float LStick2Vertical;
        Vector3 Player1Position;
        Vector3 Player2Position;
        Quaternion Player1Rotation;
        Quaternion Player2Rotation;
        bool Player1Hold;
        bool Player2Hold;
        bool pm1 = false;
        bool pm2 = false;
        // Start is called before the first frame update
        void Start()
        {
            player1spawn();
            player2spawn();
        }

        // Update is called once per frame
        void Update()
        {
            getInput();
            Getinformation();
            Playermove();
            Animation();
        }

        void getInput(){
            if (Input.GetButton("A1")){

            }
            if (Input.GetButton("A2")){

            }
            if (Input.GetButton("B1")){

            }
            if (Input.GetButton("B2")){

            }
            if (Input.GetButton("R1")){
                dash1 = 2;
            }
            else dash1 = 1;
            if (Input.GetButton("R2")){
                dash2 = 2;
            }
            else dash2 = 1;
            LStick1Horizontal = Input.GetAxis("L_Stick_H");
            LStick1Vertical = Input.GetAxis("L_Stick_V");
            LStick2Horizontal = Input.GetAxis("L_Stick_H2");
            LStick2Vertical = Input.GetAxis("L_Stick_V2");
        }

        void Getinformation(){
            Player1Position = GameObject.Find("testplayer1").transform.position;
            Player2Position = GameObject.Find("testplayer2").transform.position;
            Player1Rotation = GameObject.Find("testplayer1").transform.rotation;
            Player2Rotation = GameObject.Find("testplayer2").transform.rotation;
        }

        void Playermove(){
            FindObjectOfType<TestPlayer1>().look(testPlayerMath.Lookdirection(LStick1Horizontal, LStick1Vertical, Player1Rotation));
            FindObjectOfType<TestPlayer2>().look(testPlayerMath.Lookdirection(LStick2Horizontal, LStick2Vertical, Player2Rotation));
            if (Mathf.Abs(LStick1Horizontal) > 0 || Mathf.Abs(LStick1Vertical) > 0){
                FindObjectOfType<TestPlayer1>().Move(speed,dash1);
            }
            if (Mathf.Abs(LStick2Horizontal) > 0 || Mathf.Abs(LStick2Vertical) > 0){
                FindObjectOfType<TestPlayer2>().Move(speed,dash2);
            }
        }

        void player1spawn()
        {
            Vector3 player1spawnpoint = GameObject.Find("player1spawnpoint").transform.position;
            FindObjectOfType<TestPlayer1>().spawn(player1spawnpoint);
        }
        void player2spawn()
        {
            Vector3 player2spawnpoint = GameObject.Find("player2spawnpoint").transform.position;
            FindObjectOfType<TestPlayer2>().spawn(player2spawnpoint);
        }

        public void Checkdeth(int playernumber)
        {
            if (playernumber == 1)
            {
                player1spawn();
            }
            if (playernumber == 2)
            {
                player2spawn();
            }
        }

        void Animation()
        {
            if (pm1 == false)
            {
                if (Mathf.Abs(LStick1Horizontal) > 0 || Mathf.Abs(LStick1Vertical) > 0)
                {

                }
            }
            if (pm2 == false)
            {
                if (Mathf.Abs(LStick2Horizontal) > 0 || Mathf.Abs(LStick2Vertical) > 0)
                {

                }
            }
            if (Mathf.Abs(LStick1Horizontal) == 0 && Mathf.Abs(LStick1Vertical) == 0)
            {
                pm1 = false;
            }
            else pm1 = true;
            if (Mathf.Abs(LStick2Horizontal) == 0 && Mathf.Abs(LStick2Vertical) == 0)
            {
                pm2 = false;
            }
            else pm2 = true;
            if (Player1Hold == true)
            {

            }
            if (Player2Hold == true)
            {

            }
        }
    }

}
