using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearUIControl : MonoBehaviour
{

    List<int> clearList = new List<int>(); 
    int clearCounter;
    // Start is called before the first frame update
    void Start()
    {
        clearCounter=0;
    }

    public void AddList(int i)
    {
        clearList.Add(i);
    }

    public bool SearchList(int i)
    {
        if (clearList.Contains(i))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ClearCounter()
    {
        clearCounter++;
    }

    public bool NowClear()
    {
        if(clearCounter >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public bool GetTalent()
    {
        if (clearCounter >= 1)
        {
            clearCounter--;
            return true;
        }
        else
        {
            return false;
        }
    }
}
