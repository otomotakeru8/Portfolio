using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrintGenerator : MonoBehaviour
{
    [SerializeField, Tooltip("足跡オブジェクト")] private GameObject footPrintPrefab = null;

    private bool isStart = false;
    private float coolTime = 0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine("StartCount");
        if (isStart)
        {
            coolTime += Time.deltaTime;
        }
        if(coolTime > 0.01f)
        {
            coolTime = 0;
            Instantiate(footPrintPrefab,this.transform.position, this.transform.rotation);
        }
    }

    private IEnumerator StartCount()
    {
        yield return new WaitForSeconds(3f);
        isStart = true;
    }
}
