using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftHitting : MonoBehaviour
{
    AllSoundsScript ss;
    FeverTimeScript feverTimeScript = null;
    private GameObject taskPanel = null;
    private bool firstHit = true;
    private bool isHole = false;

    //当たった時のテキスト表示用変数
    private Vector3 offset = new Vector3(0, 3.0f, 0);//pointTextの表示場所
    [SerializeField] private GameObject pointPrefs = null; // GUITextureもしくはGUIText
    GameObject pointText = null;
    private GameObject canvas = null;


    void Start()
    {
        canvas = GameObject.Find("Canvas");
        taskPanel = GameObject.Find("TaskPanel");
        feverTimeScript = taskPanel.GetComponent<FeverTimeScript>();
        ss = GetComponent<AllSoundsScript>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (this.firstHit && this.isHole == false)
        {
            switch (other.gameObject.tag)
            {
                case "RedHouse":
                    feverTimeScript.AddScore(0);
                    HitEffects(10);
                    break;

                case "BlueHouse":
                    feverTimeScript.AddScore(1);
                    HitEffects(10);
                    break;

                case "GreenHouse":
                    feverTimeScript.AddScore(2);
                    HitEffects(10);
                    break;

                default:
                    break;

            }
            StartCoroutine("DestroyThis");
        }
        else if(this.firstHit && this.isHole)
        {
            switch (other.gameObject.tag)
            {
                case "RedHouse":
                    feverTimeScript.AddPerfectScore(0);
                    HitEffects(20);
                    break;

                case "BlueHouse":
                    feverTimeScript.AddPerfectScore(1);
                    HitEffects(20);
                    break;

                case "GreenHouse":
                    feverTimeScript.AddPerfectScore(2);
                    HitEffects(20);
                    break;

                default:
                    break;

            }
        }
    }

    void HitEffects(int point)
    {
        this.firstHit = false;
        //HitText();
        ss.PopSE(0);
    }

    IEnumerator DestroyText()
    {
        yield return new WaitForSeconds(2.0f);
        //textの削除
        Destroy(pointText);
        Destroy(this.gameObject);
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(this.gameObject);
    }

    private void HitText()
    {
        pointText = (GameObject)Instantiate(pointPrefs);
        pointText.transform.SetParent(canvas.transform, false);
        pointText.transform.position = Camera.main.WorldToScreenPoint(this.transform.position + offset);

        Text pointText2 = pointText.GetComponent<Text>();
        //pointText2.text = "+" + (point).ToString("d2");
        StartCoroutine("DestroyText");
    }
    public void HitHole()
    {
        isHole = true;
    }
}
