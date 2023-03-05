using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sea : MonoBehaviour
{
    enum Type { mae,usiro,migi,hidari}
    [SerializeField]Type type = Type.mae;
    [SerializeField]public GameObject sea;
    [SerializeField]public Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = point;
        int h = -200;
        int w = -200;
        for (int i = 0;i < 5; i++)
        {

        }
        Instantiate(sea, new Vector3(point.x, point.y, point.z + 100), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x, point.y, point.z), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x, point.y, point.z - 100), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x + 100, point.y, point.z + 100), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x + 100, point.y, point.z), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x + 100, point.y, point.z - 100), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x - 100, point.y, point.z + 100), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x - 100, point.y, point.z), Quaternion.identity, transform);
        Instantiate(sea, new Vector3(point.x - 100, point.y, point.z - 100), Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {
        switch (type)
        {
            case Type.mae:
                transform.Translate(0, 0, 0.02f);
                break;
            case Type.usiro:
                transform.Translate(0, 0, -0.02f);
                break;
            case Type.migi:
                transform.Translate(0.02f, 0, 0);
                break;
            case Type.hidari:
                transform.Translate(-0.02f, 0, 0);
                break;
        }
        if (Mathf.Abs(transform.position.x) > point.x + 100 || Mathf.Abs(transform.position.z) > point.z + 100)
        {
            transform.position = point;
        }
    }
}
