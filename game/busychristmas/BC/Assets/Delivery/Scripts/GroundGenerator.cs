using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    [SerializeField] private GameObject sRoad = null;
    [SerializeField] private GameObject branchRoad = null;
    private float posX = 0.0f;

    private float coolTime = 6.0f;
    private bool setTime = false;
    private int branchRoadCount = 100;


    void Update()
    {
        Debug.Log(branchRoadCount);
        if (setTime)
        {
            coolTime += Time.deltaTime;
        }
    }
    public void RoadGen()
    {
        if (coolTime > 2.0f)
        {
            branchRoadCount -= 1;
            posX += 70.0f;
            setTime = true;
            if (branchRoadCount >= 1)
            {
                Instantiate(sRoad, new Vector3(posX, 0.0f, 0.0f), Quaternion.identity);
                Debug.Log("s");
                coolTime = 0.0f;
            }

            if (branchRoadCount == 0)
            {
                Instantiate(branchRoad, new Vector3(posX, 0.0f, 0.0f), Quaternion.identity);
                Debug.Log("T");
                coolTime = 0.0f;
                branchRoadCount = 2;
            }   

        }
    }
}
