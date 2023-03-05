using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectData : MonoBehaviour
{
    GameObject[] saveobject;
    Transform[] transforms;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }

    public void ObjectSave(GameObject[] objects){
        for (int i = 0;i > objects.Length; i++)
        {
            transforms[i] = objects[i].transform;
        }
    }
}
