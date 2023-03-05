using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Order : MonoBehaviour
{
    [SerializeField]
    public OrderSet[] orderset;

    [System.Serializable]
    public class OrderSet
    {
        public Sprite[] item;
        public Sprite Completeitem;
    }

    public Orders[] orders;

    public class Orders
    {
        public Sprite[] item;
        public Sprite Completeitem;
    }

    bool createorder;

    // Start is called before the first frame update
    void Start()
    {
        orders = new Orders[0];
        createorder = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (orders.Length < 6)
        {
            if (createorder == true)
            {
                NewOrder();
            }
        }

    }

    void NewOrder()
    {
        createorder = false;
        orders = new Orders[(orders.Length + 1)];
        int ordersetnumber = UnityEngine.Random.Range(0,(orderset.Length - 1));
        orders[orders.Length - 1].item = orderset[ordersetnumber].item;
        orders[orders.Length - 1].Completeitem = orderset[ordersetnumber].Completeitem;
        float createordelay = UnityEngine.Random.Range(10,20);
        Invoke("CreateNewOrder",createordelay);
    }

    void CreateNewOrder()
    {
        createorder = true;
    }

    void CreateUI()
    {
        for (int i = 0;i < orders.Length; i++)
        {
            float uianchor = 0;
            if (i > 0)
            {
                for (int j = 0;j < i; j++)
                {
                    int uisize = orders[j].item.Length;
                    uianchor += ((float)uisize * 1.0f);
                }
            }
            

        }
    }
}
