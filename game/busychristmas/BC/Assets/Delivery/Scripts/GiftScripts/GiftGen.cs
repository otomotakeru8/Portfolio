using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GiftGen : MonoBehaviour
{
    public static int DeliveryPresents = 10;



    [SerializeField] private GameObject GameManager = null;//gift set用

    [SerializeField] private Image giftSprite1 = null;
    [SerializeField] private Image giftSprite2 = null;
    [SerializeField] private Sprite[] numberSprite = new Sprite[10];
    [SerializeField] private GameObject Gift = null;
    [SerializeField] private GameObject giftGround = null;

    private GameObject HandPos = null;

    SpriteRenderer gsr;
    [SerializeField] private Sprite[] groundSprite = new Sprite[2];

    private int gifts = 0;
    private bool[] isGift = new bool[2] { false, false };

    AllSoundsScript ss;

    void Start()
    {
        gsr = giftGround.GetComponent<SpriteRenderer>();
        gifts = DeliveryPresents;
        ss = GetComponent<AllSoundsScript>();
        NumberSetMethod(gifts);
        if (gifts == 0)//プレゼントを投げ切って〇秒後リザルトに移動
        {
            StartCoroutine(CountMethod(5.0f));
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            gsr.sprite = groundSprite[1];
        }
        /*if (collider.CompareTag("Player2"))
        {
            gsr.sprite = groundSprite[1];
        }*/

        if (collider.CompareTag("Player") && Input.GetButton("A1") || collider.CompareTag("Player") && Input.GetKey(KeyCode.E)) 
        {
            int playerNum = collider.GetComponent<TestPlayerCont>().getPlayerNum();
            if (gifts > 0 && isGift[playerNum] == false && playerNum == 0) 
            {
                HandPos = collider.GetComponent<TestPlayerCont>().getHandPos();
                Instantiate(Gift, HandPos.transform.position, Quaternion.identity, HandPos.transform);
                collider.GetComponent<TestPlayerCont>().haveGiftFind();
                gifts--;
                NumberSetMethod(gifts);
                
                isGift[playerNum] = true;
                ss.PopSE(0);
            }
        }

        /*if (collider.CompareTag("Player2") && Input.GetButton("A2") || collider.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            int playerNum = collider.GetComponent<TestPlayerCont>().getPlayerNum();
            if (gifts > 0 && isGift[playerNum] == false && playerNum == 1)
            {
                HandPos = collider.GetComponent<TestPlayerCont>().getHandPos();
                Instantiate(Gift, HandPos.transform.position, Quaternion.identity, HandPos.transform);
                collider.GetComponent<TestPlayerCont>().haveGiftFind();
                gifts--;
                NumberSetMethod(gifts);

                isGift[playerNum] = true;
                ss.PopSE(0);
            }
        }*/
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            gsr.sprite = groundSprite[0];
        }
        /*if (collider.CompareTag("Player2"))
        {
            gsr.sprite = groundSprite[0];
        }*/
    }

    public void throwGifted(int player)
    {
        isGift[player] = false;
        if (gifts == 0)//プレゼントを投げ切って〇秒後リザルトに移動
        {
            StartCoroutine(CountMethod(3.0f));
        }
    }

    public void NumberSetMethod(int num)
    {
        switch (num)
        {
            case 0:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[10];
                break;
            case 1:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[1];
                break;
            case 2:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[2];
                break;
            case 3:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[3];
                break;
            case 4:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[4];
                break;
            case 5:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[5];
                break;
            case 6:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[6];
                break;
            case 7:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[7];
                break;
            case 8:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[8];
                break;
            case 9:
                giftSprite1.sprite = numberSprite[0];
                giftSprite2.sprite = numberSprite[9];
                break;
            case 10:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[10];
                break;
            case 11:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[1];
                break;
            case 12:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[2];
                break;
            case 13:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[3];
                break;
            case 14:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[4];
                break;
            case 15:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[5];
                break;
            case 16:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[6];
                break;
            case 17:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[7];
                break;
            case 18:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[8];
                break;
            case 19:
                giftSprite1.sprite = numberSprite[1];
                giftSprite2.sprite = numberSprite[9];
                break;
            case 20:
                giftSprite1.sprite = numberSprite[2];
                giftSprite2.sprite = numberSprite[10];
                break;
            default:
                break;
        }
    }

    private IEnumerator CountMethod(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //ここから下にリザルトに関するメソッド記入予定        

        SceneManager.LoadScene("Result");

        //ResultChange rc = GameManager.GetComponent<ResultChange>();
        //rc.ResultStart();
    }
}
