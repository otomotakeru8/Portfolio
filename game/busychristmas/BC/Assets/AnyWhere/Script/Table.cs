using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    int ItemCapacity;
    bool craft;
    enum Tabletype{
        TABLE,
    }
    [SerializeField]
    Tabletype tabletype = Tabletype.TABLE;
    // Start is called before the first frame update
    void Start()
    {
        switch (tabletype)
        {
            case Tabletype.TABLE:

                break;
                    
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPutItem()
    {

    }
}
