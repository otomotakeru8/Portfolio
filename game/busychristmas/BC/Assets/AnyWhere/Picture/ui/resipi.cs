using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class resipi : MonoBehaviour
{

    //[0]が完成品の種類、[1]が箱の色
    [SerializeField] GameObject child4;
    [SerializeField] GameObject child3;
    [SerializeField] GameObject child2;
    [SerializeField] GameObject waku;
    [Header("ここはステージ１のなに？")]
    [SerializeField]private int stage1;
    private int iname;
    [Header("アイテム1の詳細設定(素材の数、使う素材の種類)")]
    //このステージで使用するアイテムを入れる ;
    [SerializeField] private bool useitem1;
    [SerializeField] private GameObject item1;
    //素材の数
    [Range(1.0f, 3.0f)] [SerializeField] private int item1amount;
    [SerializeField] private bool item1s1;
    [SerializeField] private bool item1s2;
    [SerializeField] private bool item1s3;
    [SerializeField] private bool item1s4;
    [Header("アイテム2の詳細設定(素材の数、使う素材の種類)")]
    [SerializeField] private bool useitem2;
    [SerializeField] private GameObject item2;
    [Range(1.0f, 3.0f)] [SerializeField] private int item2amount;
    [SerializeField] private bool item2s1;
    [SerializeField] private bool item2s2;
    [SerializeField] private bool item2s3;
    [SerializeField] private bool item2s4;
    [Header("アイテム3の詳細設定(素材の数、使う素材の種類)")]
    [SerializeField] private bool useitem3;
    [SerializeField] private GameObject item3;
    [Range(1.0f, 3.0f)] [SerializeField] private int item3amount;
    [SerializeField] private bool item3s1;
    [SerializeField] private bool item3s2;
    [SerializeField] private bool item3s3;
    [SerializeField] private bool item3s4;
    [Header("アイテム4の詳細設定(素材の数、使う素材の種類)")]
    [SerializeField] private bool useitem4;
    [SerializeField] private GameObject item4;
    [Range(1.0f, 3.0f)] [SerializeField] private int item4amount;
    [SerializeField] private bool item4s1;
    [SerializeField] private bool item4s2;
    [SerializeField] private bool item4s3;
    [SerializeField] private bool item4s4;
    [Header("このステージで使用するアイテムを入れる(素材)")]
    [SerializeField] private GameObject Sitem1;
    [SerializeField] private GameObject Sitem2;
    [SerializeField] private GameObject Sitem3;
    [SerializeField] private GameObject Sitem4;
    [Multiline(3)] public string 上の使い方;
    //出現するレシピの数
    [Header("出現するレシピの最大数")]
    public int MaxAparecer;
    [Header("出現間隔(ここの秒数+-n秒で出現)")]
    public int Aparecerclock;
    public float n秒;
    [Header("箱を入れる（入ってる）")]
    [SerializeField] private GameObject oya;
    [SerializeField] private GameObject box1;
    [SerializeField] private GameObject box2;
    [SerializeField] private GameObject box3;
    [SerializeField] private GameObject box4;
    [SerializeField] private GameObject box5;
    [SerializeField] private GameObject box6;
    bool speed = false;
    GameObject kami;
    //レシピの枚数
    private int kazu;
    //現在出てるレシピの数
    private int gkazu;
    //表示されてるレシピの要素
    private int[,] resipp;
    int selectitem;
    private GameObject[] wawawa;
    float countTime;
    float nn;
    int combo;
    private int mover;
    int l;
    int hantei;
    int loopyou, nnn;

    public string transitem1name;
    public string transitem2name;
    public string transitem3name;
    public string transitem4name;

    void Start()
    {
        hantei = 0;
        kazu = 0;
        gkazu = 0;
        combo = 0;
        wawawa = new GameObject[99];
        resipp = new int[999, 999];
        countTime = 0;
        nn = -15f;
        mover = 0;
        loopyou = 0;
        for (int i = 0; i < 999; i++)
        {
            resipp[0, i] = 0;
            resipp[2, i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        iname = 0;

        //指定した秒数ごとに発動
        if (countTime >= (Aparecerclock + nn))
        {

            nn = n秒;
            //アイテム1か2か3か4の抽選
            while (true)
            {
                selectitem = Random.Range(1, 5);
                //アイテム1のuseにチェックが入っているか
                if (selectitem == 1 && useitem1 == true)
                {
                    break;
                }
                //アイテム2のuseにチェックが入っているか
                if (selectitem == 2 && useitem2 == true)
                {
                    break;
                }
                //アイテム3のuseにチェックが入っているか
                if (selectitem == 3 && useitem3 == true)
                {
                    break;
                }
                //アイテム4のuseにチェックが入っているか
                if (selectitem == 4 && useitem4 == true)
                {
                    break;
                }
            }
            //ケーキ(アイテム1)を作るよ！！
            if (selectitem == 1 && MaxAparecer > gkazu)
            {
                gkazu++;
                countTime = 0;
                //表示されてるレシピの数+1
                //合計個数のカウント
                kazu++;
                //紙を表示
                kami = Instantiate(oya, new Vector3(960 - 842f, 540 + 410f, 0.0f), Quaternion.identity) as GameObject;
                kami.transform.parent = this.transform;
                kami.SetActive(false);
                //完成品の枠を表示する
                GameObject waku1 = Instantiate(waku, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                waku1.transform.parent = kami.transform;
                if (item1amount == 3)
                {
                    //材料の枠を表示する(4枠時)
                    GameObject c4 = Instantiate(child4, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント(ケーキ)を生成する
                    GameObject item = Instantiate(item1, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item1s1 == true)
                    {
                        //素材(パンケーキ)を生成する(4/4枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item1s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item1s1 == true)
                        {
                            //素材(クリーム)を生成する(3/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(4/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item1s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item1s1 == true && item1s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item1s4 == true)
                    {
                        //素材(?)を生成する(2/4枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            Debug.Log(k);
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }

                //枠が2の時-------------------------------------------------------------------------------------
                if (item1amount == 2)
                {
                    //材料の枠を表示する(3枠時)
                    GameObject c4 = Instantiate(child3, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item1, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item1s1 == true)
                    {
                        //素材(パンケーキ)を生成する(3/3枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item1s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item1s1 == true)
                        {
                            //素材(クリーム)を生成する(2/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(3/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item1s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item1s1 == true || item1s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item1s4 == true)
                    {
                        //素材(?)を生成する(2/3枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
                //枠が1枠の時－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
                if (item1amount == 1)
                {
                    //材料の枠を表示する(2枠時)
                    GameObject c4 = Instantiate(child2, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item1, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item1s1 == true)
                    {
                        //素材(パンケーキ)を生成する(2/2枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item1s2 == true)
                    {
                        //素材(クリーム)を生成する(2/2枠)
                        GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item3.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item1s3 == true)
                    {
                        //素材(イチゴ)を生成する(2/2枠)
                        GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item4.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item1s4 == true)
                    {
                        //素材(?)を生成する(2/2枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/2枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
            }
            //抽選で2があたったとき-----------------------------------------------------------------------------------
            if (selectitem == 2 && MaxAparecer > gkazu)
            {
                gkazu++;
                countTime = 0;
                //表示されてるレシピの数+1
                kazu++;
                //紙を表示
                kami = Instantiate(oya, new Vector3(960 - 842f, 540 + 410f, 0.0f), Quaternion.identity) as GameObject;
                kami.transform.parent = this.transform;
                kami.SetActive(false);
                //完成品の枠を表示する
                GameObject waku1 = Instantiate(waku, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                waku1.transform.parent = kami.transform;
                if (item2amount == 3)
                {
                    //材料の枠を表示する(4枠時)
                    GameObject c4 = Instantiate(child4, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント(ケーキ)を生成する
                    GameObject item = Instantiate(item2, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item2s1 == true)
                    {
                        //素材(パンケーキ)を生成する(4/4枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item2s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item2s1 == true)
                        {
                            //素材(クリーム)を生成する(3/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(4/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item2s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item2s1 == true && item2s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item2s4 == true)
                    {
                        //素材(?)を生成する(2/4枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
                //枠が2の時-------------------------------------------------------------------------------------
                if (item2amount == 2)
                {
                    //材料の枠を表示する(3枠時)
                    GameObject c4 = Instantiate(child3, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item2, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item2s1 == true)
                    {
                        //素材(パンケーキ)を生成する(3/3枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item2s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item2s1 == true)
                        {
                            //素材(クリーム)を生成する(2/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(3/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item2s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item2s1 == true || item2s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item2s4 == true)
                    {
                        //素材(?)を生成する(2/3枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
                //枠が1枠の時－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
                if (item2amount == 1)
                {
                    //材料の枠を表示する(2枠時)
                    GameObject c4 = Instantiate(child2, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item2, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item2s1 == true)
                    {
                        //素材(パンケーキ)を生成する(2/2枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item2s2 == true)
                    {
                        //素材(クリーム)を生成する(2/2枠)
                        GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item3.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item2s3 == true)
                    {
                        //素材(イチゴ)を生成する(2/2枠)
                        GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item4.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item2s4 == true)
                    {
                        //素材(?)を生成する(2/2枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/2枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
            }
            //完成品3
            if (selectitem == 3 && MaxAparecer > gkazu)
            {
                gkazu++;
                countTime = 0;
                //表示されてるレシピの数+1
                kazu++;
                //紙を表示
                kami = Instantiate(oya, new Vector3(960 - 842f, 540 + 410f, 0.0f), Quaternion.identity) as GameObject;
                kami.transform.parent = this.transform;
                kami.SetActive(false);
                //完成品の枠を表示する
                GameObject waku1 = Instantiate(waku, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                waku1.transform.parent = kami.transform;
                if (item3amount == 3)
                {
                    //材料の枠を表示する(4枠時)
                    GameObject c4 = Instantiate(child4, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント(ケーキ)を生成する
                    GameObject item = Instantiate(item3, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item3s1 == true)
                    {
                        //素材(パンケーキ)を生成する(4/4枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item3s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item3s1 == true)
                        {
                            //素材(クリーム)を生成する(3/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(4/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item3s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item3s1 == true && item3s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item3s4 == true)
                    {
                        //素材(?)を生成する(2/4枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }

                //枠が2の時-------------------------------------------------------------------------------------
                if (item3amount == 2)
                {
                    //材料の枠を表示する(3枠時)
                    GameObject c4 = Instantiate(child3, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item3, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item3s1 == true)
                    {
                        //素材(パンケーキ)を生成する(3/3枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item3s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item3s1 == true)
                        {
                            //素材(クリーム)を生成する(2/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(3/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item3s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item3s1 == true || item3s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item3s4 == true)
                    {
                        //素材(?)を生成する(2/3枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
                //枠が1枠の時－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
                if (item3amount == 1)
                {
                    //材料の枠を表示する(2枠時)
                    GameObject c4 = Instantiate(child2, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item3, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item3s1 == true)
                    {
                        //素材(パンケーキ)を生成する(2/2枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item3s2 == true)
                    {
                        //素材(クリーム)を生成する(2/2枠)
                        GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item3.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item3s3 == true)
                    {
                        //素材(イチゴ)を生成する(2/2枠)
                        GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item4.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item3s4 == true)
                    {
                        //素材(?)を生成する(2/2枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/2枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
            }
            //完成品4
            if (selectitem == 4 && MaxAparecer > gkazu)
            {
                gkazu++;
                countTime = 0;
                //表示されてるレシピの数+1
                kazu++;
                //紙を表示
                kami = Instantiate(oya, new Vector3(960 - 842f, 540 + 410f, 0.0f), Quaternion.identity) as GameObject;
                kami.transform.parent = this.transform;
                kami.SetActive(false);
                //完成品の枠を表示する
                GameObject waku1 = Instantiate(waku, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                waku1.transform.parent = kami.transform;
                if (item4amount == 3)
                {
                    //材料の枠を表示する(4枠時)
                    GameObject c4 = Instantiate(child4, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント(ケーキ)を生成する
                    GameObject item = Instantiate(item4, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item4s1 == true)
                    {
                        //素材(パンケーキ)を生成する(4/4枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item4s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item4s1 == true)
                        {
                            //素材(クリーム)を生成する(3/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(4/4枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 908f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item4s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item4s1 == true && item4s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/4枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 870f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item4s4 == true)
                    {
                        //素材(?)を生成する(2/4枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 823f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 780f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }

                //枠が2の時-------------------------------------------------------------------------------------
                if (item4amount == 2)
                {
                    //材料の枠を表示する(3枠時)
                    GameObject c4 = Instantiate(child3, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item4, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item4s1 == true)
                    {
                        //素材(パンケーキ)を生成する(3/3枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item4s2 == true)
                    {
                        //1枠目か2枠目かの判定
                        if (item4s1 == true)
                        {
                            //素材(クリーム)を生成する(2/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(クリーム)を生成する(3/3枠)
                            GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item3.transform.parent = kami.transform;
                        }
                    }
                    //この素材を今回使うかの判定
                    if (item4s3 == true)
                    {
                        //どの枠に入るかの判定
                        if (item4s1 == true || item4s2 == true)
                        {
                            //素材(イチゴ)を生成する(2/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                        else
                        {
                            //素材(イチゴ)を生成する(3/3枠)
                            GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 880f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                            item4.transform.parent = kami.transform;
                        }
                    }
                    if (item4s4 == true)
                    {
                        //素材(?)を生成する(2/3枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 845f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/4枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 807f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
                //枠が1枠の時－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
                if (item4amount == 1)
                {
                    //材料の枠を表示する(2枠時)
                    GameObject c4 = Instantiate(child2, new Vector3(960f, 540f, 0.0f), Quaternion.identity) as GameObject;
                    c4.transform.parent = kami.transform;
                    //プレゼント（ケーキ）の作成
                    GameObject item = Instantiate(item4, new Vector3(960 - 840f, 540 + 445f, 0.0f), Quaternion.identity) as GameObject;
                    item.transform.parent = kami.transform;
                    //この素材を今回使うかの判定
                    if (item4s1 == true)
                    {
                        //素材(パンケーキ)を生成する(2/2枠)
                        GameObject item2 = Instantiate(Sitem1, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item2.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item4s2 == true)
                    {
                        //素材(クリーム)を生成する(2/2枠)
                        GameObject item3 = Instantiate(Sitem2, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item3.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item4s3 == true)
                    {
                        //素材(イチゴ)を生成する(2/2枠)
                        GameObject item4 = Instantiate(Sitem3, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item4.transform.parent = kami.transform;
                    }
                    //この素材を今回使うかの判定
                    if (item4s4 == true)
                    {
                        //素材(?)を生成する(2/2枠)
                        GameObject item5 = Instantiate(Sitem4, new Vector3(960 - 860f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    //素材(箱)を生成する(1/2枠)
                    //↓箱の色抽選。
                    int boxcolar = Random.Range(1, 7);
                    //1 紫 2 ピンク 3 赤 4 青 5 黄色 6 緑
                    if (boxcolar == 1)
                    {
                        GameObject item5 = Instantiate(box1, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 2)
                    {
                        GameObject item5 = Instantiate(box2, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 3)
                    {
                        GameObject item5 = Instantiate(box3, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 4)
                    {
                        GameObject item5 = Instantiate(box4, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 5)
                    {
                        GameObject item5 = Instantiate(box5, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    else if (boxcolar == 6)
                    {
                        GameObject item5 = Instantiate(box6, new Vector3(960 - 825f, 540 + 350f, 0.0f), Quaternion.identity) as GameObject;
                        item5.transform.parent = kami.transform;
                    }
                    resipp[kazu, 1] = boxcolar;
                    /*resipp[kazu,0] = selectitem;
                    resipp[kazu,1] = boxcolar;*/

                    //(すでにあるレシピの数を考慮して)レシピの紙を表示する
                    for (int k = 0; k < 99; k++)
                    {
                        if (gkazu - 1 == k)
                        {
                            kami.transform.position = new Vector3(960 - 825 - hantei + (k - loopyou) * 195, 540 + 650f, 0f);
                            kami.SetActive(true);
                            speed = true;
                        }
                    }
                }
            }
            if (countTime == 0)
            {
                Debug.Log(kazu);
                wawawa[kazu] = kami;
                resipp[kazu, 0] = selectitem;
                //resipp[kazu, 1] 箱の色の情報は個々で入力済み;
                resipp[kazu, 2] = 1;
            }
        }

        //情報を受け取った(と仮定した)処理
        if (item != null)
        {
            int getitennumber = 0;
            int getboxnumber = 0;
            if (item1.name == "お菓子詰め合わせ") transitem1name = "Assort";
            if (item1.name == "飛行機") transitem1name = "Airplane";
            if (item1.name == "パーカー　修正後") transitem1name = "BlackClothes";
            if (item1.name == "マフラー青") transitem1name = "BlueScarf";
            if (item1.name == "") transitem1name = "Book";
            if (item1.name == "ケーキ１") transitem1name = "Cake";
            if (item1.name == "車") transitem1name = "Car";
            if (item1.name == "") transitem1name = "ChocolateCake";
            if (item1.name == "ぬいぐるみ") transitem1name = "Dool";
            if (item1.name == "ゲーム機") transitem1name = "GameConsole";
            if (item1.name == "ラジコン") transitem1name = "Radiocontroller";
            if (item1.name == "巫女福") transitem1name = "RedClothes";
            if (item1.name == "マフラー赤") transitem1name = "RedScarf";
            if (item1.name == "ロボット") transitem1name = "Robot";
            if (item1.name == "ソフト") transitem1name = "Software";
            if (item1.name == "水着　修正後") transitem1name = "WhiteClothes";
            if (item.name.Contains(transitem1name))
            {
                getitennumber = 1;
                if (item.name.Contains("Blue"))
                {
                    getboxnumber = 4;
                }
                if (item.name.Contains("Green"))
                {
                    getboxnumber = 6;
                }
                if (item.name.Contains("Pink"))
                {
                    getboxnumber = 2;
                }
                if (item.name.Contains("Red"))
                {
                    getboxnumber = 3;
                }
                if (item.name.Contains("Yello"))
                {
                    getboxnumber = 5;
                }
                if (item.name.Contains("Purple"))
                {
                    getboxnumber = 1;
                }
            }
            if (item2.name == "お菓子詰め合わせ") transitem2name = "Assort";
            if (item2.name == "飛行機") transitem2name = "Airplane";
            if (item2.name == "パーカー　修正後") transitem2name = "BlackClothes";
            if (item2.name == "マフラー青") transitem2name = "BlueScarf";
            if (item2.name == "") transitem2name = "Book";
            if (item2.name == "ケーキ１") transitem2name = "Cake";
            if (item2.name == "車") transitem2name = "Car";
            if (item2.name == "") transitem2name = "ChocolateCake";
            if (item2.name == "ぬいぐるみ") transitem2name = "Dool";
            if (item2.name == "ゲーム機") transitem2name = "GameConsole";
            if (item2.name == "ラジコン") transitem2name = "Radiocontroller";
            if (item2.name == "巫女福") transitem2name = "RedClothes";
            if (item2.name == "マフラー赤") transitem2name = "RedScarf";
            if (item2.name == "ロボット") transitem2name = "Robot";
            if (item2.name == "ソフト") transitem2name = "Software";
            if (item2.name == "水着　修正後") transitem2name = "WhiteClothes";
            if (item.name.Contains(transitem2name))
            {
                getitennumber = 1;
                if (item.name.Contains("Blue"))
                {
                    getboxnumber = 4;
                }
                if (item.name.Contains("Green"))
                {
                    getboxnumber = 6;
                }
                if (item.name.Contains("Pink"))
                {
                    getboxnumber = 2;
                }
                if (item.name.Contains("Red"))
                {
                    getboxnumber = 3;
                }
                if (item.name.Contains("Yello"))
                {
                    getboxnumber = 5;
                }
                if (item.name.Contains("Purple"))
                {
                    getboxnumber = 1;
                }
            }
            if (item3.name == "お菓子詰め合わせ") transitem3name = "Assort";
            if (item3.name == "飛行機") transitem3name = "Airplane";
            if (item3.name == "パーカー　修正後") transitem3name = "BlackClothes";
            if (item3.name == "マフラー青") transitem3name = "BlueScarf";
            if (item3.name == "") transitem3name = "Book";
            if (item3.name == "ケーキ１") transitem3name = "Cake";
            if (item3.name == "車") transitem3name = "Car";
            if (item3.name == "") transitem3name = "ChocolateCake";
            if (item3.name == "ぬいぐるみ") transitem3name = "Dool";
            if (item3.name == "ゲーム機") transitem3name = "GameConsole";
            if (item3.name == "ラジコン") transitem3name = "Radiocontroller";
            if (item3.name == "巫女福") transitem3name = "RedClothes";
            if (item3.name == "マフラー赤") transitem3name = "RedScarf";
            if (item3.name == "ロボット") transitem3name = "Robot";
            if (item3.name == "ソフト") transitem3name = "Software";
            if (item3.name == "水着　修正後") transitem3name = "WhiteClothes";
            if (item.name.Contains(transitem3name))
            {
                getitennumber = 1;
                if (item.name.Contains("Blue"))
                {
                    getboxnumber = 4;
                }
                if (item.name.Contains("Green"))
                {
                    getboxnumber = 6;
                }
                if (item.name.Contains("Pink"))
                {
                    getboxnumber = 2;
                }
                if (item.name.Contains("Red"))
                {
                    getboxnumber = 3;
                }
                if (item.name.Contains("Yello"))
                {
                    getboxnumber = 5;
                }
                if (item.name.Contains("Purple"))
                {
                    getboxnumber = 1;
                }
            }
            if (item4.name == "お菓子詰め合わせ") transitem4name = "Assort";
            if (item4.name == "飛行機") transitem4name = "Airplane";
            if (item4.name == "パーカー　修正後") transitem4name = "BlackClothes";
            if (item4.name == "マフラー青") transitem4name = "BlueScarf";
            if (item4.name == "") transitem4name = "Book";
            if (item4.name == "ケーキ１") transitem4name = "Cake";
            if (item4.name == "車") transitem4name = "Car";
            if (item4.name == "") transitem4name = "ChocolateCake";
            if (item4.name == "ぬいぐるみ") transitem4name = "Dool";
            if (item4.name == "ゲーム機") transitem4name = "GameConsole";
            if (item4.name == "ラジコン") transitem4name = "Radiocontroller";
            if (item4.name == "巫女福") transitem4name = "RedClothes";
            if (item4.name == "マフラー赤") transitem4name = "RedScarf";
            if (item4.name == "ロボット") transitem4name = "Robot";
            if (item4.name == "ソフト") transitem4name = "Software";
            if (item4.name == "水着　修正後") transitem4name = "WhiteClothes";
            if (item.name.Contains(transitem4name))
            {
                getitennumber = 1;
                if (item.name.Contains("Blue"))
                {
                    getboxnumber = 4;
                }
                if (item.name.Contains("Green"))
                {
                    getboxnumber = 6;
                }
                if (item.name.Contains("Pink"))
                {
                    getboxnumber = 2;
                }
                if (item.name.Contains("Red"))
                {
                    getboxnumber = 3;
                }
                if (item.name.Contains("Yello"))
                {
                    getboxnumber = 5;
                }
                if (item.name.Contains("Purple"))
                {
                    getboxnumber = 1;
                }
            }
            //色々変数宣言
            if (stage1 == 1)
            {
                if (item.name == "RedScarf")
                {
                    iname=1;
                }else if(item.name == "BlueScarf")
                {
                    iname = 2;
                }
            }
            for (int i = 0; i <= kazu; i++)
            {
                //受け取った完成品の情報と一致しているレシピを左から探す
                //受け取る情報、とりあえず1にしました。デバック用。
                if (resipp[i, 0] == iname && resipp[i, 2] == 1)
                {
                    iname = 0;
                    //箱も一致しているかの確認
                    //とりあえず1にしました。
                    if (resipp[i, 1] == getboxnumber)
                    {
                        //コンボを加算　
                        //エフェクトとか付けてもいいかもね！！(丸投げ)
                        combo++;
                    }
                    else
                    {
                        //箱が一致してないのでコンボ没収
                        combo = 0;
                    }
                    mover++;
                    if (l > 0)
                    {
                        nnn = i;
                    }
                    else
                    {
                        l = i;
                    }
                    loopyou=-1;
                    Destroy(wawawa[i]);
                    GiftGen.DeliveryPresents += 1;
                    resipp[i, 2] = 0;
                    gkazu--;
                    break;
                }
                else
                {
                    //レシピにない商品を作ったため、死にます。
                    //ゲームオーバーの効果音とかならせばいいと思う。
                }
            }
            //レシピの削除、それに伴う左詰め
            item = null;
        }
    }
    void FixedUpdate()
    {
        //レシピを上から降らせる
        if (speed == true)
        {
            kami.transform.position -= new Vector3(0f, 5.5f, 0f);
            if (kami.transform.position.y <= 540 + 420f)
            {
                speed = false;
            }
        }
        //倉庫窓から情報を受け取る
        //デバック用のinputスペース

        if (mover >= 1)
        {
            for (int j = 1; j <= 99; j++)
            {
                if (resipp[l + j, 2] == 1)
                {
                    wawawa[(l + j)].transform.position += new Vector3(-5f, 0f, 0f);
                }
            }
            hantei += 5;
        }
        if (hantei >= 195)
        {
            hantei = 0;
            mover--;
            l = 0;
            if (mover == 1)
            {
                l = nnn;
            }
        }
    }

    public GameObject item = null;
    public void Getitem(GameObject item)
    {
        this.item = item; 
    }
}
