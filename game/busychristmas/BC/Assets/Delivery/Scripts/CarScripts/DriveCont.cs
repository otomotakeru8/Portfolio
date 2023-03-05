using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCont : MonoBehaviour
{
    private bool isRight = false;
    private bool isLeft = false;

    [SerializeField] private float speed = 0.1f;

    private float forward = 0f;
    private float right = 0f;

    void Update()
    {
        this.transform.Translate(right * Time.deltaTime, 0f, forward * Time.deltaTime);
    }

    public void StartCar()
    {
        forward = 1f * speed;
    }

    public void ChoiceRight()
    {
        isRight = true;
        isLeft = false;
    }

    public void ChoiceLeft()
    {
        isLeft = true;
        isRight = false;
    }
        
    public void TurningCar()
    {
        if (isRight)
        {
            forward = 0f;
            StartCoroutine("RightMove");
        }
        if (isLeft)
        {
            forward = 0f;
            StartCoroutine("LeftMove");
        }
    }

   //右にゆっくり回転して60°でストップ
    IEnumerator RightMove()
    {
        for (int turn = 0; turn < 120; turn++)
        {
            transform.Rotate(0f, 0.5f, 0f);
            yield return new WaitForSeconds(0.001f);
            Debug.Log("Right");
        }
        StartCoroutine("StopCar");
    }

    //左にゆっくり回転して60°でストップ
    IEnumerator LeftMove()
    {
        for (int turn = 0; turn < 120; turn++)
        {
            transform.Rotate(0f, -0.5f, 0f);
            yield return new WaitForSeconds(0.001f);
            Debug.Log("Left");
        }
        StartCoroutine("StopCar");
    }

    IEnumerator StopCar()
    {
        yield return new WaitForSeconds(0.01f);
        isRight = false;
        isLeft = false;
        Debug.Log("start");
        forward = 1f * speed;
    }
}
