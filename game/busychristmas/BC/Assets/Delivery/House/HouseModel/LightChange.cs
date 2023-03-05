using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    [SerializeField] Light[] lightComp = new Light[4]; 

    Color colorSet = new Color32(255,255,255,1);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeliveryGift"))
        {
            for(int i = 0;i < lightComp.Length; i++)
            {
                lightComp[i].color = colorSet;
                lightComp[i].intensity = 5;
            }
        }
    }

    public void SetHoleColor()
    {
        colorSet = new Color32(255,255,0,1);
    }
}
