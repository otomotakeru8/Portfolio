using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllGetterSetter : MonoBehaviour
{
    private int giftQuantity = 10;
    private int deliveryScore = 0;

    public void SetGiftQuantity(int gifts)
    {
        giftQuantity = gifts;
    }

    public int GetGiftQuantity()
    {
        return giftQuantity;
    }

    public void SetDeliveryScore(int score)
    {
        deliveryScore = score;
    }

    public int GetDeliveryScore()
    {
        return deliveryScore;
    }

}
