using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkUI : MonoBehaviour
{
    float timeline;
    GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        ui = transform.Find("uiobject").gameObject;
        timeline = 0;
        Invoke("Done",2f);
    }

    // Update is called once per frame
    void Update()
    {
        timeline += Time.deltaTime;
        ui.transform.localScale = new Vector3(0.2f,timeline * 0.25f,0.2f);
        ui.transform.localPosition = new Vector3(timeline * 0.25f - 0.5f,1.51f,0);
    }

    void Done()
    {

        Destroy(this.gameObject);
    }
}
