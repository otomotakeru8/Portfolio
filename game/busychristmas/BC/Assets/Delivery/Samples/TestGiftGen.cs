using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestGiftGen : MonoBehaviour
{

    [SerializeField] private GameObject Gift = null;
    [SerializeField] private GameObject HandPos = null;
    private int gifts = 10;
    private bool isGift = false;

    AllSoundsScript ss;

    void Start()
    {
        ss = GetComponent<AllSoundsScript>();
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("Player") && Input.GetKey("joystick button 0") && isGift == false || collider.CompareTag("Player") && Input.GetKey(KeyCode.E) && isGift == false)
        {
            if (gifts > 0)
            {
                Instantiate(Gift, HandPos.transform.position, Quaternion.identity, HandPos.transform);
                collider.GetComponent<TestPlayerCont>().haveGiftFind();
                gifts--;
                isGift = true;
            }
        }
    }
    public void throwGifted()
    {
        isGift = false;
    }
}
