using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkDesk : MonoBehaviour
{
    GameObject RedWool; GameObject BlueWool; GameObject Pancake; GameObject Cream; GameObject ChocolateCream; GameObject Strawberry; GameObject Paper; GameObject Leather; GameObject Iron; GameObject Rubber; GameObject Plastic; GameObject ConductingWire; GameObject Soft; GameObject CSoft; GameObject Package; GameObject Candy; GameObject Cookie; GameObject Chocolate; GameObject RedCloth; GameObject BlackCloth; GameObject WhiteCloth; GameObject Cotton; GameObject Cloth; GameObject RedScarf; GameObject BlueScarf; GameObject Book; GameObject Car; GameObject Airplane; GameObject Cake; GameObject ChocolateCake; GameObject GameConsole; GameObject Software; GameObject Assort; GameObject Robot; GameObject Radiocotrolled; GameObject Dool; GameObject RedClothes; GameObject BlackClothes; GameObject WhiteClothes; GameObject PinkGift; GameObject RedGift; GameObject YellowGift; GameObject GreenGift; GameObject BlueGift; GameObject PurpleGift; GameObject Ribbon; GameObject GamePackage;
    GameObject PinkRedScarf; GameObject RedRedScarf; GameObject YellowRedScarf; GameObject GreenRedScarf; GameObject BlueRedScarf; GameObject PurpleRedScarf;
    GameObject PinkBlueScarf; GameObject RedBlueScarf; GameObject YellowBlueScarf; GameObject GreenBlueScarf; GameObject BlueBlueScarf; GameObject PurpleBlueScarf;
    GameObject PinkBook; GameObject RedBook; GameObject YellowBook; GameObject GreenBook; GameObject BlueBook; GameObject PurpleBook;
    GameObject PinkCar; GameObject RedCar; GameObject YellowCar; GameObject GreenCar; GameObject BlueCar; GameObject PurpleCar;
    GameObject PinkAirplane; GameObject RedAirplane; GameObject YellowAirplane; GameObject GreenAirplane; GameObject BlueAirplane; GameObject PurpleAirplane;
    GameObject PinkCake; GameObject RedCake; GameObject YellowCake; GameObject GreenCake; GameObject BlueCake; GameObject PurpleCake;
    GameObject PinkChocolateCake; GameObject RedChocolateCake; GameObject YellowChocolateCake; GameObject GreenChocolateCake; GameObject BlueChocolateCake; GameObject PurpleChocolateCake;
    GameObject PinkGameConsole; GameObject RedGameConsole; GameObject YellowGameConsole; GameObject GreenGameConsole; GameObject BlueGameConsole; GameObject PurpleGameConsole;
    GameObject PinkSoftware; GameObject RedSoftware; GameObject YellowSoftware; GameObject GreenSoftware; GameObject BlueSoftware; GameObject PurpleSoftware;
    GameObject PinkAssort; GameObject RedAssort; GameObject YellowAssort; GameObject GreenAssort; GameObject BlueAssort; GameObject PurpleAssort;
    GameObject PinkRobot; GameObject RedRobot; GameObject YellowRobot; GameObject GreenRobot; GameObject BlueRobot; GameObject PurpleRobot;
    GameObject PinkRadiocotrolled; GameObject RedRadiocotrolled; GameObject YellowRadiocotrolled; GameObject GreenRadiocotrolled; GameObject BlueRadiocotrolled; GameObject PurpleRadiocotrolled;
    GameObject PinkDool; GameObject RedDool; GameObject YellowDool; GameObject GreenDool; GameObject BlueDool; GameObject PurpleDool;
    GameObject PinkRedClothes; GameObject RedRedClothes; GameObject YellowRedClothes; GameObject GreenRedClothes; GameObject BlueRedClothes; GameObject PurpleRedClothes;
    GameObject PinkBlackClothes; GameObject RedBlackClothes; GameObject YellowBlackClothes; GameObject GreenBlackClothes; GameObject BlueBlackClothes; GameObject PurpleBlackClothes;
    GameObject PinkWhiteClothes; GameObject RedWhiteClothes; GameObject YellowWhiteClothes; GameObject GreenWhiteClothes; GameObject BlueWhiteClothes; GameObject PurpleWhiteClothes;

    GameObject Sugar; GameObject Water; GameObject CCream; GameObject Egg; GameObject CChocolate; GameObject CIron; GameObject CPlastic; GameObject CRubber; GameObject CCIron; GameObject CCPlastic; GameObject Controller; GameObject CPaper; GameObject CLeather; GameObject CStrawberry; GameObject CPancake; GameObject Bag; GameObject CCandy; GameObject PinkController; GameObject RedController; GameObject YellowController; GameObject GreenController; GameObject BlueController; GameObject PurpleController; GameObject Squeezing; GameObject CCCream; GameObject CChocolateCream; GameObject MIron; GameObject MPlastic; GameObject MPancake;


    bool redScarf;
    bool CanItem, redWool, blueWool, paper, leather, iron, rubber, plastic, pancake, cream, chocolateCream, strawberry, conductingWire, package, candy, cookie, chocolate, redCloth, blackCloth, whiteCloth, soft, cSoft, gamePackage, cotton, cloth;
    bool ribbon, pinkGift, redGift, yellowGift, greenGift, blueGift, purpleGift, blueScarf, book, car, airplane, cake, chocolateCake, gameConsole, software, assort, robot, radiocotrolled, dool, redClothes, blackClothes, whiteClothes;
    bool pinkRedScarf, pinkBlueScarf, pinkBook, pinkCar, pinkAirplane, pinkCake, pinkChocolateCake, pinkGameConsole, pinkSoftware, pinkAssort, pinkRobot, pinkRadiocotrolled, pinkDool, pinkRedClothes, pinkBlackClothes, pinkWhiteClothes;
    bool redRedScarf, redBlueScarf, redBook, redCar, redAirplane, redCake, redChocolateCake, redGameConsole, redSoftware, redAssort, redRobot, redRadiocotrolled, redDool, redRedClothes, redBlackClothes, redWhiteClothes;
    bool yellowRedScarf, yellowBlueScarf, yellowBook, yellowCar, yellowAirplane, yellowChocolateCake, yellowCake, yellowGameConsole, yellowSoftware, yellowAssort, yellowRobot, yellowRadiocotrolled, yellowDool, yellowRedClothes, yellowBlackClothes, yellowWhiteClothes;
    bool greenRedScarf, greenBlueScarf, greenBook, greenCar, greenAirplane, greenChocolateCake, greenCake, greenGameConsole, greenSoftware, greenAssort, greenRobot, greenRadiocotrolled, greenDool, greenRedClothes, greenBlackClothes, greenWhiteClothes;
    bool blueRedScarf, blueBlueScarf, blueBook, blueCar, blueAirplane, blueChocolateCake, blueCake, blueGameConsole, blueSoftware, blueAssort, blueRobot, blueRadiocotrolled, blueDool, blueRedClothes, blueBlackClothes, blueWhiteClothes;
    bool purpleRedScarf, purpleBlueScarf, purpleBook, purpleCar, purpleAirplane, purpleChocolateCake, purpleCake, purpleGameConsole, purpleSoftware, purpleAssort, purpleRobot, purpleRadiocotrolled, purpleDool, purpleRedClothes, purpleBlackClothes, purpleWhiteClothes;

    bool sugar, water, egg, cCream, cChocolate, cCIron, cRubber, cCPlastic, controller, cPaper, cLeather, cStrawberry, bag, cCandy, pinkController, redController, yellowController, greenController, blueController, purpleController, squeezing, cCCream, cChocolateCream;
    bool cPancake, mPancake, cIron, mIron, cPlastic, mPlastic;

    int IHaveItem = 0;
    //kyukyo
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        /*子オブジェクトを削除
        Destroy(gameObject.transform.Find("Capsule1(Clone)").gameObject);
        //Invokeで実行しているCall関数を5秒後に停止する
        CancelInvoke("Call");

        //関数名を記述しなければInvoke系全てを停止する
        CancelInvoke();*/

        setFalse();

        RedWool = (GameObject)Resources.Load("RedWool");
        BlueWool = (GameObject)Resources.Load("BlueWool");
        Pancake = (GameObject)Resources.Load("Pancake");
        Cream = (GameObject)Resources.Load("Cream");
        ChocolateCream = (GameObject)Resources.Load("ChocolateCream");
        Strawberry = (GameObject)Resources.Load("Strawberry");
        Paper = (GameObject)Resources.Load("Paper");
        Leather = (GameObject)Resources.Load("Leather");
        Iron = (GameObject)Resources.Load("Iron");
        Rubber = (GameObject)Resources.Load("Rubber");
        Plastic = (GameObject)Resources.Load("Plastic");
        ConductingWire = (GameObject)Resources.Load("ConductingWire ");
        Soft = (GameObject)Resources.Load("Soft");
        CSoft = (GameObject)Resources.Load("CSoft");
        Package = (GameObject)Resources.Load("Package");
        Candy = (GameObject)Resources.Load("Candy");
        Cookie = (GameObject)Resources.Load("Cookie");
        Chocolate = (GameObject)Resources.Load("Chocolate");
        RedCloth = (GameObject)Resources.Load("RedCloth");
        BlackCloth = (GameObject)Resources.Load("BlackCloth");
        WhiteCloth = (GameObject)Resources.Load("WhiteCloth");
        Cotton = (GameObject)Resources.Load("Cotton");
        Cloth = (GameObject)Resources.Load("Cloth");
        RedScarf = (GameObject)Resources.Load("RedScarf");
        BlueScarf = (GameObject)Resources.Load("BlueScarf");
        Book = (GameObject)Resources.Load("Book");
        Car = (GameObject)Resources.Load("Car");
        Airplane = (GameObject)Resources.Load("Airplane");
        Cake = (GameObject)Resources.Load("Cake");
        ChocolateCake = (GameObject)Resources.Load("ChocolateCake");
        GameConsole = (GameObject)Resources.Load("GameConsole");
        Software = (GameObject)Resources.Load("Software");
        Assort = (GameObject)Resources.Load("Assort");
        Robot = (GameObject)Resources.Load("Robot");
        Radiocotrolled = (GameObject)Resources.Load("Radiocotrolled");
        Dool = (GameObject)Resources.Load("Dool");
        RedClothes = (GameObject)Resources.Load("RedClothes");
        BlackClothes = (GameObject)Resources.Load("BlackClothes");
        WhiteClothes = (GameObject)Resources.Load("WhiteClothes");
        PinkGift = (GameObject)Resources.Load("PinkGift");
        RedGift = (GameObject)Resources.Load("RedGift");
        YellowGift = (GameObject)Resources.Load("YellowGift");
        GreenGift = (GameObject)Resources.Load("GreenGift");
        BlueGift = (GameObject)Resources.Load("BlueGift");
        PurpleGift = (GameObject)Resources.Load("PurpleGift");
        Ribbon = (GameObject)Resources.Load("Ribbon");
        GamePackage = (GameObject)Resources.Load("GamePackage");
        PinkRedScarf = (GameObject)Resources.Load("PinkRedScarf");
        RedRedScarf = (GameObject)Resources.Load("RedRedScarf");
        YellowRedScarf = (GameObject)Resources.Load("YellowRedScarf");
        GreenRedScarf = (GameObject)Resources.Load("GreenRedScarf");
        BlueRedScarf = (GameObject)Resources.Load("BlueRedScarf");
        PurpleRedScarf = (GameObject)Resources.Load("PurpleRedScarf");
        PinkBlueScarf = (GameObject)Resources.Load("PinkBlueScarf");
        RedBlueScarf = (GameObject)Resources.Load("RedBlueScarf");
        YellowBlueScarf = (GameObject)Resources.Load("YellowBlueScarf");
        GreenBlueScarf = (GameObject)Resources.Load("GreenBlueScarf");
        BlueBlueScarf = (GameObject)Resources.Load("BlueBlueScarf");
        PurpleBlueScarf = (GameObject)Resources.Load("PurpleBlueScarf");
        PinkBook = (GameObject)Resources.Load("PinkBook");
        RedBook = (GameObject)Resources.Load("RedBook");
        YellowBook = (GameObject)Resources.Load("YellowBook");
        GreenBook = (GameObject)Resources.Load("GreenBook");
        BlueBook = (GameObject)Resources.Load("BlueBook");
        PurpleBook = (GameObject)Resources.Load("PurpleBook");
        PinkCar = (GameObject)Resources.Load("PinkCar");
        RedCar = (GameObject)Resources.Load("RedCar");
        YellowCar = (GameObject)Resources.Load("YellowCar");
        GreenCar = (GameObject)Resources.Load("GreenCar");
        BlueCar = (GameObject)Resources.Load("BlueCar");
        PurpleCar = (GameObject)Resources.Load("PurpleCar");
        PinkAirplane = (GameObject)Resources.Load("PinkAirplane");
        RedAirplane = (GameObject)Resources.Load("RedAirplane");
        YellowAirplane = (GameObject)Resources.Load("YellowAirplane");
        GreenAirplane = (GameObject)Resources.Load("GreenAirplane");
        BlueAirplane = (GameObject)Resources.Load("BlueAirplane");
        PurpleAirplane = (GameObject)Resources.Load("PurpleAirplane");
        PinkCake = (GameObject)Resources.Load("PinkCake");
        RedCake = (GameObject)Resources.Load("RedCake");
        YellowCake = (GameObject)Resources.Load("YellowCake");
        GreenCake = (GameObject)Resources.Load("GreenCake");
        BlueCake = (GameObject)Resources.Load("BlueCake");
        PurpleCake = (GameObject)Resources.Load("PurpleCake");
        PinkChocolateCake = (GameObject)Resources.Load("PinkChocolateCake");
        RedChocolateCake = (GameObject)Resources.Load("RedChocolateCake");
        YellowChocolateCake = (GameObject)Resources.Load("YellowChocolateCake");
        GreenChocolateCake = (GameObject)Resources.Load("GreenChocolateCake");
        BlueChocolateCake = (GameObject)Resources.Load("BlueChocolateCake");
        PurpleChocolateCake = (GameObject)Resources.Load("PurpleChocolateCake");
        PinkGameConsole = (GameObject)Resources.Load("PinkGameConsole");
        RedGameConsole = (GameObject)Resources.Load("RedGameConsole");
        YellowGameConsole = (GameObject)Resources.Load("YellowGameConsole");
        GreenGameConsole = (GameObject)Resources.Load("GreenGameConsole");
        BlueGameConsole = (GameObject)Resources.Load("BlueGameConsole");
        PurpleGameConsole = (GameObject)Resources.Load("PurpleGameConsole");
        PinkSoftware = (GameObject)Resources.Load("PinkSoftware");
        RedSoftware = (GameObject)Resources.Load("RedSoftware");
        YellowSoftware = (GameObject)Resources.Load("YellowSoftware");
        GreenSoftware = (GameObject)Resources.Load("GreenSoftware");
        BlueSoftware = (GameObject)Resources.Load("BlueSoftware");
        PurpleSoftware = (GameObject)Resources.Load("PurpleSoftware");
        PinkAssort = (GameObject)Resources.Load("PinkAssort");
        RedAssort = (GameObject)Resources.Load("RedAssort");
        YellowAssort = (GameObject)Resources.Load("YellowAssort");
        GreenAssort = (GameObject)Resources.Load("GreenAssort");
        BlueAssort = (GameObject)Resources.Load("BlueAssort");
        PurpleAssort = (GameObject)Resources.Load("PurpleAssort");
        PinkRobot = (GameObject)Resources.Load("PinkRobot");
        RedRobot = (GameObject)Resources.Load("RedRobot");
        YellowRobot = (GameObject)Resources.Load("YellowRobot");
        GreenRobot = (GameObject)Resources.Load("GreenRobot");
        BlueRobot = (GameObject)Resources.Load("BlueRobot");
        PurpleRobot = (GameObject)Resources.Load("PurpleRobot");
        PinkRadiocotrolled = (GameObject)Resources.Load("PinkRadiocotrolled");
        RedRadiocotrolled = (GameObject)Resources.Load("RedRadiocotrolled");
        YellowRadiocotrolled = (GameObject)Resources.Load("YellowRadiocotrolled");
        GreenRadiocotrolled = (GameObject)Resources.Load("GreenRadiocotrolled");
        BlueRadiocotrolled = (GameObject)Resources.Load("BlueRadiocotrolled");
        PurpleRadiocotrolled = (GameObject)Resources.Load("PurpleRadiocotrolled");
        PinkDool = (GameObject)Resources.Load("PinkDool");
        RedDool = (GameObject)Resources.Load("RedDool");
        YellowDool = (GameObject)Resources.Load("YellowDool");
        GreenDool = (GameObject)Resources.Load("GreenDool");
        BlueDool = (GameObject)Resources.Load("BlueDool");
        PurpleDool = (GameObject)Resources.Load("PurpleDool");
        PinkRedClothes = (GameObject)Resources.Load("PinkRedClothes");
        RedRedClothes = (GameObject)Resources.Load("RedRedClothes");
        YellowRedClothes = (GameObject)Resources.Load("YellowRedClothes");
        GreenRedClothes = (GameObject)Resources.Load("GreenRedClothes");
        BlueRedClothes = (GameObject)Resources.Load("BlueRedClothes");
        PurpleRedClothes = (GameObject)Resources.Load("PurpleRedClothes");
        PinkBlackClothes = (GameObject)Resources.Load("PinkBlackClothes ");
        RedBlackClothes = (GameObject)Resources.Load("RedBlackClothes");
        YellowBlackClothes = (GameObject)Resources.Load("YellowBlackClothes");
        GreenBlackClothes = (GameObject)Resources.Load("GreenBlackClothes");
        BlueBlackClothes = (GameObject)Resources.Load("BlueBlackClothes");
        PurpleBlackClothes = (GameObject)Resources.Load("PurpleBlackClothes");
        PinkWhiteClothes = (GameObject)Resources.Load("PinkWhiteClothes");
        RedWhiteClothes = (GameObject)Resources.Load("RedWhiteClothes");
        YellowWhiteClothes = (GameObject)Resources.Load("YellowWhiteClothes");
        GreenWhiteClothes = (GameObject)Resources.Load("GreenWhiteClothes");
        BlueWhiteClothes = (GameObject)Resources.Load("BlueWhiteClothes");
        PurpleWhiteClothes = (GameObject)Resources.Load("PurpleWhiteClothes");
        //tuika
        Sugar = (GameObject)Resources.Load("Sugar");
        Water = (GameObject)Resources.Load("Water");
        Egg = (GameObject)Resources.Load("Egg");
        CCream = (GameObject)Resources.Load("CCream");
        CChocolate = (GameObject)Resources.Load("CChocolate");
        CIron = (GameObject)Resources.Load("CIron");
        CPlastic = (GameObject)Resources.Load("CPlastic");
        CRubber = (GameObject)Resources.Load("CRubber");
        CCIron = (GameObject)Resources.Load("CCIron");
        CCPlastic = (GameObject)Resources.Load("CCPlastic");
        Controller = (GameObject)Resources.Load("Controller");
        CPaper = (GameObject)Resources.Load("CPaper");
        CLeather = (GameObject)Resources.Load("CLeather");
        CStrawberry = (GameObject)Resources.Load("CStrawberry");
        CPancake = (GameObject)Resources.Load("CPancake");
        Bag = (GameObject)Resources.Load("Bag");
        PinkController = (GameObject)Resources.Load("PinkController");
        RedController = (GameObject)Resources.Load("RedController");
        YellowController = (GameObject)Resources.Load("YellowController");
        GreenController = (GameObject)Resources.Load("GreenController");
        BlueController = (GameObject)Resources.Load("BlueController");
        PurpleController = (GameObject)Resources.Load("PurpleController");
        Squeezing = (GameObject)Resources.Load("Squeezing");
        CCCream = (GameObject)Resources.Load("CCCream");
        CChocolateCream = (GameObject)Resources.Load("CChocolateCream");
        MIron = (GameObject)Resources.Load("MIron");
        MPlastic = (GameObject)Resources.Load("MPlastic");
        MPancake = (GameObject)Resources.Load("MPancake");

        //きゅきょ
        obj = GameObject.Find("Canvas/レシピ");
    }

    private void Update()
    {

    }
    public enum WorkDesk_TYPE
    {
        knittingNeedle, //編み棒
        pencil,  //鉛筆
        sewingMachine,  //ミシン
        hearth,//かまど
        pot, //鍋
        pc,   //パソコン
        cuttingBoard, //まな板
        whisk, //泡だて器
        crossbow, //トンカチ
        desk,//机
        trash //ゴミ箱
    }

    [SerializeField] public WorkDesk_TYPE tYPE;
    public bool set(string SetItem)
    {
        bool reply = false;
        if (CanItem == false)
        {
            Debug.Log("set");
            if (tYPE == WorkDesk_TYPE.trash)
            {
                reply = true;
                if((SetItem == "RedScarf"))
                {
                    obj.GetComponent<resipi>().Getitem(RedScarf);
                }
                if ((SetItem == "BlueScarf"))
                {
                    obj.GetComponent<resipi>().Getitem(BlueScarf);
                }
            }
            if (tYPE == WorkDesk_TYPE.knittingNeedle)//RedWool BlueWool
            {
                if (redScarf == false && blueScarf == false)
                {
                    if ((SetItem == "RedWool") && redWool == false && blueWool == false)
                    {
                        Debug.Log("setred");
                        reply = true;
                        redWool = true;
                        var parent = this.transform;
                        Instantiate(RedWool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueWool") && redWool == false && blueWool == false)
                    {
                        reply = true;
                        blueWool = true;
                        var parent = this.transform;
                        Instantiate(BlueWool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.pencil) //Paper 
            {
                if ((SetItem == "Paper") && paper == false && CPaper == false)
                {
                    reply = true;
                    paper = true;
                    var parent = this.transform;
                    Instantiate(Paper, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
            }
            if (tYPE == WorkDesk_TYPE.sewingMachine)//RedCloth BlackCloth WhiteCloth Cloth Cotton
            {
                if (redClothes == false && blackClothes == false && whiteClothes == false && Dool == false)
                {
                    if ((SetItem == "RedCloth") && redCloth == false && blackCloth == false && whiteCloth == false && cloth == false && cotton == false)
                    {
                        reply = true;
                        redCloth = true;
                        var parent = this.transform;
                        Instantiate(RedCloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlackCloth") && redCloth == false && blackCloth == false && whiteCloth == false && cloth == false && cotton == false)
                    {
                        reply = true;
                        blackCloth = true;
                        var parent = this.transform;
                        Instantiate(BlackCloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "WhiteCloth") && redCloth == false && blackCloth == false && whiteCloth == false && cloth == false && cotton == false)
                    {
                        reply = true;
                        whiteCloth = true;
                        var parent = this.transform;
                        Instantiate(WhiteCloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Cloth") && redCloth == false && blackCloth == false && whiteCloth == false && cloth == false && cotton == false)
                    {
                        reply = true;
                        cloth = true;
                        var parent = this.transform;
                        Instantiate(Cloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Cotton") && redCloth == false && blackCloth == false && whiteCloth == false && cloth == false && cotton == false)
                    {
                        reply = true;
                        cotton = true;
                        var parent = this.transform;
                        Instantiate(Cotton, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.hearth) //Iron Plastic Pancake
            {
                if (cIron == false && cPlastic == false && cPancake == false)
                {
                    if ((SetItem == "Iron") && iron == false && plastic == false && pancake == false)
                    {
                        reply = true;
                        iron = true;
                        //オブジェクトの色を赤に変更する
                        GetComponent<Renderer>().material.color = Color.red;
                        //作業開始４秒で完成３秒後焦げる。
                        Invoke("CompleteIron", 4.0f);
                        Invoke("MissIron", 7.0f);
                    }
                    if ((SetItem == "Plastic") && iron == false && plastic == false && pancake == false)
                    {
                        reply = true;
                        plastic = true;
                        //オブジェクトの色を赤に変更する
                        GetComponent<Renderer>().material.color = Color.red;
                        //作業開始４秒で完成３秒後焦げる。
                        Invoke("CompletePlastic", 4.0f);
                        Invoke("MissPlastic", 7.0f);
                    }
                    if ((SetItem == "Pancake") && iron == false && plastic == false && pancake == false)
                    {
                        reply = true;
                        pancake = true;
                        //オブジェクトの色を赤に変更する
                        GetComponent<Renderer>().material.color = Color.red;
                        //作業開始４秒で完成３秒後焦げる。
                        Invoke("CompletePancake", 4.0f);
                        Invoke("MissPancake", 7.0f);
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.pot) //sugar, water
            {
                if (Candy == false)
                {
                    if ((SetItem == "Sugar") && sugar == false)
                    {
                        reply = true;
                        sugar = true;
                    }
                    if ((SetItem == "Water") && water == false)
                    {
                        reply = true;
                        water = true;
                    }
                    if (sugar == true && water == true)
                    {
                        Invoke("CompleteCandy", 3.0f);
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.pc) //Soft ConductingWire
            {
                if (cSoft == false)
                {
                    int i = 0;
                    if (i <= 2)
                    {
                        if ((SetItem == "Soft") && soft == false && conductingWire == false)
                        {
                            i++;
                            reply = true;
                            soft = true;
                            var parent = this.transform;
                            Instantiate(Soft, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                        }
                    }
                    if (i >= 3)
                    {
                        if ((SetItem == "ConductingWire") && conductingWire == false)
                        {
                            i = 0;
                            reply = true;
                            conductingWire = true;
                            var parent = this.transform;
                            Instantiate(ConductingWire, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                        }
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.cuttingBoard) //Strawberry Chocolate
            {
                if (cStrawberry == false && cChocolate == false)
                {
                    if ((SetItem == "Strawberry") && strawberry == false)
                    {
                        reply = true;
                        strawberry = true;
                        var parent = this.transform;
                        Instantiate(Strawberry, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Chocolate") && chocolate == false)
                    {
                        reply = true;
                        chocolate = true;
                        var parent = this.transform;
                        Instantiate(Chocolate, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.whisk) //Egg Cream CCream CChocolate
            {
                if (cake == false && chocolateCake == false)
                {
                    if ((SetItem == "Egg") && egg == false && cChocolate == false && cCream == false)
                    {
                        reply = true;
                        egg = true;
                    }
                    if ((SetItem == "Cream") && cream == false && cChocolate == false && cCream == false)
                    {
                        reply = true;
                        cream = true;
                    }
                    if ((SetItem == "CCream") && cCream == false && cream == false && egg == false)
                    {
                        reply = true;
                        cCream = true;
                    }
                    if ((SetItem == "CChocolate") && cChocolate == false && cream == false && egg == false)
                    {
                        reply = true;
                        cChocolate = true;
                    }
                    if (egg == true && cream == true)
                    {
                        Invoke("CompleteCream", 3.0f);
                    }
                    if (cCream == true && cChocolate == true)
                    {
                        Invoke("CompleteChocolateCream", 3.0f);
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.crossbow) //Leather　Rubber CRubber　CIron CCIron CPlastic CCPlastic ConductingWire
            {
                if (book == false && car == false && gameConsole == false && radiocotrolled == false && Controller == false)
                {
                    if ((SetItem == "Leather") && leather == false && rubber == false && cIron == false && cPlastic == false && conductingWire == false && cCIron == false && cRubber == false && cCPlastic == false)
                    {
                        reply = true;
                        leather = true;
                        var parent = this.transform;
                        Instantiate(Leather, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Rubber") && leather == false && rubber == false && cIron == false && cPlastic == false && conductingWire == false && cCIron == false && cRubber == false && cCPlastic == false)
                    {
                        reply = true;
                        rubber = true;
                        var parent = this.transform;
                        Instantiate(Rubber, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CIron") && leather == false && rubber == false && cIron == false && cPlastic == false && conductingWire == false && cCIron == false && cRubber == false && cCPlastic == false)
                    {
                        reply = true;
                        cIron = true;
                        var parent = this.transform;
                        Instantiate(CIron, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CPlastic") && leather == false && rubber == false && cIron == false && cPlastic == false && conductingWire == false && cCIron == false && cRubber == false && cCPlastic == false)
                    {
                        reply = true;
                        cPlastic = true;
                        var parent = this.transform;
                        Instantiate(CPlastic, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "ConductingWire") && leather == false && rubber == false && cIron == false && cPlastic == false && conductingWire == false)
                    {
                        reply = true;
                        conductingWire = true;
                        var parent = this.transform;
                        Instantiate(ConductingWire, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CCIron") && leather == false && rubber == false && cIron == false && cPlastic == false && cCIron == false && cCPlastic == false)
                    {
                        reply = true;
                        cCIron = true;
                        var parent = this.transform;
                        Instantiate(CCIron, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CRubber") && leather == false && rubber == false && cIron == false && cPlastic == false && cRubber == false && cCPlastic == false)
                    {
                        reply = true;
                        cRubber = true;
                        var parent = this.transform;
                        Instantiate(CRubber, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CCPlastic") && leather == false && rubber == false && cIron == false && cPlastic == false && cCIron == false && cRubber == false && cCPlastic == false)
                    {
                        reply = true;
                        cCPlastic = true;
                        var parent = this.transform;
                        Instantiate(CCPlastic, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                }
            }
            if (tYPE == WorkDesk_TYPE.desk)
            {
                //ラッピング
                if ((SetItem == "RedScarf") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    redScarf = true;
                    var parent = this.transform;
                    Instantiate(RedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "BlueScarf") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    blueScarf = true;
                    var parent = this.transform;
                    Instantiate(BlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "Book") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    book = true;
                    var parent = this.transform;
                    Instantiate(Book, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "Car") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    car = true;
                    var parent = this.transform;
                    Instantiate(Car, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "Airplane") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    airplane = true;
                    var parent = this.transform;
                    Instantiate(Airplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "Cake") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    cake = true;
                    var parent = this.transform;
                    Instantiate(Cake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "ChocolateCake") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    chocolateCake = true;
                    var parent = this.transform;
                    Instantiate(ChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "GameConsole") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    gameConsole = true;
                    var parent = this.transform;
                    Instantiate(GameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "GameConsole") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    gameConsole = true;
                    var parent = this.transform;
                    Instantiate(GameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);

                }
                if ((SetItem == "Software") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    software = true;
                    var parent = this.transform;
                    Instantiate(Software, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "Assort") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    assort = true;
                    var parent = this.transform;
                    Instantiate(Assort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "Robot") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    robot = true;
                    var parent = this.transform;
                    Instantiate(Robot, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "Radiocotrolled") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    radiocotrolled = true;
                    var parent = this.transform;
                    Instantiate(Radiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "Controller") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    controller = true;
                    var parent = this.transform;
                    Instantiate(Controller, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "Dool") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    dool = true;
                    var parent = this.transform;
                    Instantiate(Dool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "RedClothes") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    redClothes = true;
                    var parent = this.transform;
                    Instantiate(RedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "BlackClothes") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    blackClothes = true;
                    var parent = this.transform;
                    Instantiate(BlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "WhiteClothes") && redScarf == false && blueScarf == false && book == false && car == false && airplane == false && cake == false && chocolateCake == false && gameConsole == false && gameConsole == false && software == false && assort == false && robot == false && radiocotrolled == false && controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false)
                {
                    reply = true;
                    whiteClothes = true;
                    var parent = this.transform;
                    Instantiate(WhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }

                if ((SetItem == "PinkGift") && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false)
                {
                    reply = true;
                    pinkGift = true;
                    var parent = this.transform;
                    Instantiate(PinkGift, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "RedGift") && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false)
                {
                    reply = true;
                    redGift = true;
                    var parent = this.transform;
                    Instantiate(RedGift, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "YellowGift") && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false)
                {
                    reply = true;
                    yellowGift = true;
                    var parent = this.transform;
                    Instantiate(YellowGift, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "GreenGift") && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false)
                {
                    reply = true;
                    greenGift = true;
                    var parent = this.transform;
                    Instantiate(GreenGift, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "GreenGift") && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false)
                {
                    reply = true;
                    blueGift = true;
                    var parent = this.transform;
                    Instantiate(BlueGift, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "PurpleGift") && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false)
                {
                    reply = true;
                    purpleGift = true;
                    var parent = this.transform;
                    Instantiate(PurpleGift, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                if ((SetItem == "Ribbon") && ribbon == false)
                {
                    reply = true;
                    ribbon = true;
                    var parent = this.transform;
                    Instantiate(Ribbon, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                }
                //机でやる合成
                if (RedScarf == false && BlueScarf == false && Book == false && Car == false && Airplane == false && ChocolateCake == false && Cake == false && GameConsole == false && Software == false && Assort == false && Robot == false && Radiocotrolled == false && Controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false && ribbon == false)
                {
                    if ((SetItem == "CPaper") && cPaper == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)//本
                    {
                        reply = true;
                        cPaper = true;
                        var parent = this.transform;
                        Instantiate(CPaper, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CLeather") && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        cLeather = true;
                        var parent = this.transform;
                        Instantiate(CLeather, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CCIron") && cPaper == false && cLeather == false && cCIron == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)//飛行機
                    {
                        reply = true;
                        cCIron = true;
                        var parent = this.transform;
                        Instantiate(CCIron, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CRubber") && cPaper == false && cLeather == false && cRubber == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        cRubber = true;
                        var parent = this.transform;
                        Instantiate(CRubber, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CCPlastic") && cPaper == false && cLeather == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        cCPlastic = true;
                        var parent = this.transform;
                        Instantiate(CCPlastic, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CPancake") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)//ケーキ
                    {
                        reply = true;
                        cPancake = true;
                        var parent = this.transform;
                        Instantiate(CPancake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CStrawberry") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cStrawberry == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        cStrawberry = true;
                        var parent = this.transform;
                        Instantiate(CStrawberry, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CCream") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false)
                    {
                        reply = true;
                        cCream = true;
                        var parent = this.transform;
                        Instantiate(CCream, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CChocolate") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && chocolate == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        cChocolate = true;
                        var parent = this.transform;
                        Instantiate(CChocolate, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "ChocolateCream") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && cChocolate == false)
                    {
                        reply = true;
                        chocolateCream = true;
                        var parent = this.transform;
                        Instantiate(ChocolateCream, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CSoft") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)//ゲームソフト
                    {
                        reply = true;
                        cSoft = true;
                        var parent = this.transform;
                        Instantiate(CSoft, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GamePackage") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        gamePackage = true;
                        var parent = this.transform;
                        Instantiate(GamePackage, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Candy") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)//キャンディー
                    {
                        reply = true;
                        candy = true;
                        var parent = this.transform;
                        Instantiate(Candy, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Bag") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        bag = true;
                        var parent = this.transform;
                        Instantiate(Bag, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CCandy") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && cCCream == false && squeezing == false && cChocolate == false)//お菓子の詰め合わせ
                    {
                        reply = true;
                        cCandy = true;
                        var parent = this.transform;
                        Instantiate(CCandy, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Chocolate") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && chocolate == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        chocolate = true;
                        var parent = this.transform;
                        Instantiate(Chocolate, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Cookie") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cookie == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        cookie = true;
                        var parent = this.transform;
                        Instantiate(Cookie, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Package") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        package = true;
                        var parent = this.transform;
                        Instantiate(Package, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CCCream") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && cChocolate == false)
                    {
                        reply = true;
                        cCCream = true;
                        var parent = this.transform;
                        Instantiate(CCCream, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Squeezing") && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && squeezing == false && cChocolate == false)
                    {
                        reply = true;
                        squeezing = true;
                        var parent = this.transform;
                        Instantiate(Squeezing, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                }
                //一つだけ机においておくすべて書き出す　
                if (RedScarf == false && BlueScarf == false && Book == false && Car == false && Airplane == false && ChocolateCake == false && Cake == false && GameConsole == false && Software == false && Assort == false && Robot == false && Radiocotrolled == false && Controller == false && dool == false && redClothes == false && blackClothes == false && whiteClothes == false && pinkGift == false && redGift == false && yellowGift == false && greenGift == false && blueGift == false && purpleGift == false && ribbon == false
                    && cPaper == false && cLeather == false && cCIron == false && cRubber == false && cCPlastic == false && cPancake == false && cStrawberry == false && cCream == false && chocolateCream == false && cSoft == false && gamePackage == false && candy == false && bag == false && cCandy == false && chocolate == false && cookie == false && package == false && cCCream == false && squeezing == false && cChocolate == false)
                {Debug.Log("ha");
                    if ((SetItem == "RedWool") && IHaveItem == 0)
                    {
                        Debug.Log("hai");
                        reply = true;
                        redWool = true;
                        var parent = this.transform;
                        Instantiate(RedWool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueWool") && IHaveItem == 0)
                    {
                        reply = true;
                        blueWool = true;
                        var parent = this.transform;
                        Instantiate(BlueWool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Paper") && IHaveItem == 0)
                    {
                        reply = true;
                        paper = true;
                        var parent = this.transform;
                        Instantiate(Paper, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Leather") && IHaveItem == 0)
                    {
                        reply = true;
                        leather = true;
                        var parent = this.transform;
                        Instantiate(Leather, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedCloth") && IHaveItem == 0)
                    {
                        reply = true;
                        redCloth = true;
                        var parent = this.transform;
                        Instantiate(RedCloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlackCloth") && IHaveItem == 0)
                    {
                        reply = true;
                        blackCloth = true;
                        var parent = this.transform;
                        Instantiate(BlackCloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "WhiteCloth") && IHaveItem == 0)
                    {
                        reply = true;
                        whiteCloth = true;
                        var parent = this.transform;
                        Instantiate(WhiteCloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Cloth") && IHaveItem == 0)
                    {
                        reply = true;
                        cloth = true;
                        var parent = this.transform;
                        Instantiate(Cloth, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Cotton") && IHaveItem == 0)
                    {
                        reply = true;
                        cotton = true;
                        var parent = this.transform;
                        Instantiate(Cotton, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Iron") && IHaveItem == 0)
                    {
                        reply = true;
                        iron = true;
                        var parent = this.transform;
                        Instantiate(Iron, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Plastic") && IHaveItem == 0)
                    {
                        reply = true;
                        plastic = true;
                        var parent = this.transform;
                        Instantiate(Plastic, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Pancake") && IHaveItem == 0)
                    {
                        reply = true;
                        pancake = true;
                        var parent = this.transform;
                        Instantiate(Pancake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Sugar") && IHaveItem == 0)
                    {
                        reply = true;
                        sugar = true;
                        var parent = this.transform;
                        Instantiate(Sugar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Soft") && IHaveItem == 0)
                    {
                        reply = true;
                        soft = true;
                        var parent = this.transform;
                        Instantiate(Soft, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Strawberry") && IHaveItem == 0)
                    {
                        reply = true;
                        strawberry = true;
                        var parent = this.transform;
                        Instantiate(Strawberry, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Chocolate") && IHaveItem == 0)
                    {
                        reply = true;
                        chocolate = true;
                        var parent = this.transform;
                        Instantiate(Chocolate, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Egg") && IHaveItem == 0)
                    {
                        reply = true;
                        egg = true;
                        var parent = this.transform;
                        Instantiate(Egg, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Cream") && IHaveItem == 0)
                    {
                        reply = true;
                        cream = true;
                        var parent = this.transform;
                        Instantiate(Cream, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "Rubber") && IHaveItem == 0)
                    {
                        reply = true;
                        rubber = true;
                        var parent = this.transform;
                        Instantiate(Rubber, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "ConductingWire") && IHaveItem == 0)
                    {
                        reply = true;
                        conductingWire = true;
                        var parent = this.transform;
                        Instantiate(ConductingWire, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CIron") && IHaveItem == 0)
                    {
                        reply = true;
                        cIron = true;
                        var parent = this.transform;
                        Instantiate(CIron, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "CPlastic") && IHaveItem == 0)
                    {
                        reply = true;
                        cPlastic = true;
                        var parent = this.transform;
                        Instantiate(CPlastic, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkRedScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkRedScarf = true;
                        var parent = this.transform;
                        Instantiate(PinkRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkBlueScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkBlueScarf = true;
                        var parent = this.transform;
                        Instantiate(PinkBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkBook") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkBook = true;
                        var parent = this.transform;
                        Instantiate(PinkBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkCar") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkCar = true;
                        var parent = this.transform;
                        Instantiate(PinkCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkAirplane") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkAirplane = true;
                        var parent = this.transform;
                        Instantiate(PinkAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkCake") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkCake = true;
                        var parent = this.transform;
                        Instantiate(PinkCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkChocolateCake") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkChocolateCake = true;
                        var parent = this.transform;
                        Instantiate(PinkChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkSoftware") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkSoftware = true;
                        var parent = this.transform;
                        Instantiate(PinkSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkGameConsole") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkGameConsole = true;
                        var parent = this.transform;
                        Instantiate(PinkGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkRadiocotrolled") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkRadiocotrolled = true;
                        var parent = this.transform;
                        Instantiate(PinkRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkController") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkController = true;
                        var parent = this.transform;
                        Instantiate(PinkController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkRedClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkRedClothes = true;
                        var parent = this.transform;
                        Instantiate(PinkRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkBlackClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkBlackClothes = true;
                        var parent = this.transform;
                        Instantiate(PinkBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkWhiteClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkWhiteClothes = true;
                        var parent = this.transform;
                        Instantiate(PinkWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkAssort") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkAssort = true;
                        var parent = this.transform;
                        Instantiate(PinkAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PinkDool") && IHaveItem == 0)
                    {
                        reply = true;
                        pinkDool = true;
                        var parent = this.transform;
                        Instantiate(PinkDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedRedScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        redRedScarf = true;
                        var parent = this.transform;
                        Instantiate(RedRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedBlueScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        redBlueScarf = true;
                        var parent = this.transform;
                        Instantiate(RedBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedBook") && IHaveItem == 0)
                    {
                        reply = true;
                        redBook = true;
                        var parent = this.transform;
                        Instantiate(RedBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedCar") && IHaveItem == 0)
                    {
                        reply = true;
                        redCar = true;
                        var parent = this.transform;
                        Instantiate(RedCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedAirplane") && IHaveItem == 0)
                    {
                        reply = true;
                        redAirplane = true;
                        var parent = this.transform;
                        Instantiate(RedAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedCake") && IHaveItem == 0)
                    {
                        reply = true;
                        redCake = true;
                        var parent = this.transform;
                        Instantiate(RedCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedChocolateCake") && IHaveItem == 0)
                    {
                        reply = true;
                        redChocolateCake = true;
                        var parent = this.transform;
                        Instantiate(RedChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedSoftware") && IHaveItem == 0)
                    {
                        reply = true;
                        redSoftware = true;
                        var parent = this.transform;
                        Instantiate(RedSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedGameConsole") && IHaveItem == 0)
                    {
                        reply = true;
                        redGameConsole = true;
                        var parent = this.transform;
                        Instantiate(RedGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedRadiocotrolled") && IHaveItem == 0)
                    {
                        reply = true;
                        redRadiocotrolled = true;
                        var parent = this.transform;
                        Instantiate(RedRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedController") && IHaveItem == 0)
                    {
                        reply = true;
                        redController = true;
                        var parent = this.transform;
                        Instantiate(RedController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedRedClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        redRedClothes = true;
                        var parent = this.transform;
                        Instantiate(RedRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedBlackClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        redBlackClothes = true;
                        var parent = this.transform;
                        Instantiate(RedBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedWhiteClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        redWhiteClothes = true;
                        var parent = this.transform;
                        Instantiate(RedWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedAssort") && IHaveItem == 0)
                    {
                        reply = true;
                        redAssort = true;
                        var parent = this.transform;
                        Instantiate(RedAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "RedDool") && IHaveItem == 0)
                    {
                        reply = true;
                        redDool = true;
                        var parent = this.transform;
                        Instantiate(RedDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowRedScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowRedScarf = true;
                        var parent = this.transform;
                        Instantiate(YellowRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowBlueScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowBlueScarf = true;
                        var parent = this.transform;
                        Instantiate(YellowBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowBook") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowBook = true; var parent = this.transform;
                        Instantiate(YellowBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowCar") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowCar = true;
                        var parent = this.transform;
                        Instantiate(YellowCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowAirplane") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowAirplane = true;
                        var parent = this.transform;
                        Instantiate(YellowAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowCake") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowCake = true;
                        var parent = this.transform;
                        Instantiate(YellowCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowChocolateCake") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowChocolateCake = true;
                        var parent = this.transform;
                        Instantiate(YellowChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowSoftware") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowSoftware = true;
                        var parent = this.transform;
                        Instantiate(YellowSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowGameConsole") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowGameConsole = true;
                        var parent = this.transform;
                        Instantiate(YellowGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowRadiocotrolled") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowRadiocotrolled = true;
                        var parent = this.transform;
                        Instantiate(YellowRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowController") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowController = true;
                        var parent = this.transform;
                        Instantiate(YellowController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowRedClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowRedClothes = true;
                        var parent = this.transform;
                        Instantiate(YellowRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowBlackClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowBlackClothes = true;
                        var parent = this.transform;
                        Instantiate(YellowBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowWhiteClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowWhiteClothes = true;
                        var parent = this.transform;
                        Instantiate(YellowWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowAssort") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowAssort = true;
                        var parent = this.transform;
                        Instantiate(YellowAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "YellowDool") && IHaveItem == 0)
                    {
                        reply = true;
                        yellowDool = true;
                        var parent = this.transform;
                        Instantiate(YellowDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenRedScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        greenRedScarf = true;
                        var parent = this.transform;
                        Instantiate(GreenRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenBlueScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        greenBlueScarf = true;
                        var parent = this.transform;
                        Instantiate(GreenBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenBook") && IHaveItem == 0)
                    {
                        reply = true;
                        greenBook = true;
                        var parent = this.transform;
                        Instantiate(GreenBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenCar") && IHaveItem == 0)
                    {
                        reply = true;
                        greenCar = true;
                        var parent = this.transform;
                        Instantiate(GreenCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenAirplane") && IHaveItem == 0)
                    {
                        reply = true;
                        greenAirplane = true;
                        var parent = this.transform;
                        Instantiate(GreenAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenCake") && IHaveItem == 0)
                    {
                        reply = true;
                        greenCake = true;
                        var parent = this.transform;
                        Instantiate(GreenCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenChocolateCake") && IHaveItem == 0)
                    {
                        reply = true;
                        greenChocolateCake = true;
                        var parent = this.transform;
                        Instantiate(GreenChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenSoftware") && IHaveItem == 0)
                    {
                        reply = true;
                        greenSoftware = true;
                        var parent = this.transform;
                        Instantiate(GreenSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenGameConsole") && IHaveItem == 0)
                    {
                        reply = true;
                        greenGameConsole = true;
                        var parent = this.transform;
                        Instantiate(GreenGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenRadiocotrolled") && IHaveItem == 0)
                    {
                        reply = true;
                        greenRadiocotrolled = true;
                        var parent = this.transform;
                        Instantiate(GreenRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenController") && IHaveItem == 0)
                    {
                        reply = true;
                        greenController = true;
                        var parent = this.transform;
                        Instantiate(GreenController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenRedClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        greenRedClothes = true;
                        var parent = this.transform;
                        Instantiate(GreenRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenBlackClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        greenBlackClothes = true;
                        var parent = this.transform;
                        Instantiate(GreenBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenWhiteClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        greenWhiteClothes = true;
                        var parent = this.transform;
                        Instantiate(GreenWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenAssort") && IHaveItem == 0)
                    {
                        reply = true;
                        greenAssort = true;
                        var parent = this.transform;
                        Instantiate(GreenAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "GreenDool") && IHaveItem == 0)
                    {
                        reply = true;
                        greenDool = true;
                        var parent = this.transform;
                        Instantiate(GreenDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueRedScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        blueRedScarf = true;
                        var parent = this.transform;
                        Instantiate(BlueRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueBlueScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        blueBlueScarf = true;
                        var parent = this.transform;
                        Instantiate(BlueBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueBook") && IHaveItem == 0)
                    {
                        reply = true;
                        blueBook = true;
                        var parent = this.transform;
                        Instantiate(BlueBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueCar") && IHaveItem == 0)
                    {
                        reply = true;
                        blueCar = true;
                        var parent = this.transform;
                        Instantiate(BlueCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueAirplane") && IHaveItem == 0)
                    {
                        reply = true;
                        blueAirplane = true;
                        var parent = this.transform;
                        Instantiate(BlueAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueCake") && IHaveItem == 0)
                    {
                        reply = true;
                        blueCake = true;
                        var parent = this.transform;
                        Instantiate(BlueCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueChocolateCake") && IHaveItem == 0)
                    {
                        reply = true;
                        blueChocolateCake = true;
                        var parent = this.transform;
                        Instantiate(BlueChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueSoftware") && IHaveItem == 0)
                    {
                        reply = true;
                        blueSoftware = true;
                        var parent = this.transform;
                        Instantiate(BlueSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueGameConsole") && IHaveItem == 0)
                    {
                        reply = true;
                        blueGameConsole = true;
                        var parent = this.transform;
                        Instantiate(BlueGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueRadiocotrolled") && IHaveItem == 0)
                    {
                        reply = true;
                        blueRadiocotrolled = true;
                        var parent = this.transform;
                        Instantiate(BlueRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueController") && IHaveItem == 0)
                    {
                        reply = true;
                        blueController = true;
                        var parent = this.transform;
                        Instantiate(BlueController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueRedClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        blueRedClothes = true;
                        var parent = this.transform;
                        Instantiate(BlueRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueBlackClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        blueBlackClothes = true;
                        var parent = this.transform;
                        Instantiate(BlueBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueWhiteClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        blueWhiteClothes = true;
                        var parent = this.transform;
                        Instantiate(BlueWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueAssort") && IHaveItem == 0)
                    {
                        reply = true;
                        blueAssort = true;
                        var parent = this.transform;
                        Instantiate(BlueAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "BlueDool") && IHaveItem == 0)
                    {
                        reply = true;
                        blueDool = true;
                        var parent = this.transform;
                        Instantiate(BlueDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleRedScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleRedScarf = true;
                        var parent = this.transform;
                        Instantiate(PurpleRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleBlueScarf") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleBlueScarf = true;
                        var parent = this.transform;
                        Instantiate(PurpleBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleBook") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleBook = true;
                        var parent = this.transform;
                        Instantiate(PurpleBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleCar") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleCar = true;
                        var parent = this.transform;
                        Instantiate(PurpleCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleAirplane") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleAirplane = true;
                        var parent = this.transform;
                        Instantiate(PurpleAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleCake") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleCake = true;
                        var parent = this.transform;
                        Instantiate(PurpleCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleChocolateCake") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleChocolateCake = true;
                        var parent = this.transform;
                        Instantiate(PurpleChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleSoftware") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleSoftware = true;
                        var parent = this.transform;
                        Instantiate(PurpleSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleGameConsole") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleGameConsole = true;
                        var parent = this.transform;
                        Instantiate(PurpleGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleRadiocotrolled") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleRadiocotrolled = true;
                        var parent = this.transform;
                        Instantiate(PurpleRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleController") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleController = true;
                        var parent = this.transform;
                        Instantiate(PurpleController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleRedClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleRedClothes = true;
                        var parent = this.transform;
                        Instantiate(PurpleRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleBlackClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleBlackClothes = true;
                        var parent = this.transform;
                        Instantiate(PurpleBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleWhiteClothes") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleWhiteClothes = true;
                        var parent = this.transform;
                        Instantiate(PurpleWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleAssort") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleAssort = true;
                        var parent = this.transform;
                        Instantiate(PurpleAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                    if ((SetItem == "PurpleDool") && IHaveItem == 0)
                    {
                        reply = true;
                        purpleDool = true;
                        var parent = this.transform;
                        Instantiate(PurpleDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                    }
                }
            }
        }
        if (reply == true)
        {
            IHaveItem += 1;
        }
        return reply;
    }
    public bool work()
    {
        bool canwork = false;
        if (tYPE == WorkDesk_TYPE.knittingNeedle)
        {
            if (redWool == true)
            {
                Debug.Log("work");
                redWool = false; redScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                Invoke("Redbaka",2.0f);
            }
            if (blueWool == true)
            {
                blueWool = false; blueScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                Invoke("Bluebaka",2.0f);
                
            }
        }
        if (tYPE == WorkDesk_TYPE.pencil)
        {
            if (cPaper == true && cLeather == true)
            {
                cPaper = false; cLeather = false; book = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Book, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CPaper(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CLeather(Clone)").gameObject);
            }
        }
        if (tYPE == WorkDesk_TYPE.sewingMachine)
        {
            if (redCloth == true)
            {
                redCloth = false; redClothes = true; canwork = true;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedCloth(Clone)").gameObject);
            }
            if (blackCloth == true)
            {
                blackCloth = false; blackClothes = true; canwork = true;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlackCloth(Clone)").gameObject);
            }
            if (whiteCloth == true)
            {
                whiteCloth = false; whiteClothes = true; canwork = true;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(WhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("WhiteCloth(Clone)").gameObject);
            }
            if (cloth == true && cotton == true)
            {
                cloth = false; cotton = false; dool = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Dool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Cotton(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Cloth(Clone)").gameObject);
            }
        }
        if (tYPE == WorkDesk_TYPE.pc)
        {
            if (soft == true)
            {
                soft = false; cSoft = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CSoft, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                //子オブジェクトを削除
                Destroy(gameObject.transform.Find("Soft(Clone)").gameObject);
            }
            if (conductingWire == true)
            {
                conductingWire = false; canwork = true; IHaveItem = 0;
                //UIにゲージの開始を伝える
                Destroy(gameObject.transform.Find("ConductingWire(Clone)").gameObject);
            }
        }
        if (tYPE == WorkDesk_TYPE.cuttingBoard)
        {
            if (strawberry == true)
            {
                strawberry = false; cStrawberry = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CStrawberry, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Strawberry(Clone)").gameObject);
            }
            if (chocolate == true)
            {
                chocolate = false; cChocolate = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CChocolate, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Chocolate(Clone)").gameObject);
            }
        }
        if (tYPE == WorkDesk_TYPE.crossbow)
        {
            if (leather == true)
            {
                leather = false; cLeather = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CLeather, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Leather(Clone)").gameObject);
            }
            if (rubber == true)
            {
                rubber = false; cRubber = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CRubber, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Rubber(Clone)").gameObject);
            }
            if (cIron == true)
            {
                cIron = false; cCIron = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CCIron, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CIron(Clone)").gameObject);
            }
            if (cPlastic == true)
            {
                cPlastic = false; cCPlastic = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CCPlastic, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CPlastic(Clone)").gameObject);
            }
            if (cRubber == true && cCIron == true && conductingWire == false && cCPlastic == false)//車
            {
                cRubber = false; cCIron = false; car = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Car, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CRubber(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CCIron(Clone)").gameObject);
            }
            if (cRubber == true && cCIron == true && cCPlastic == true)//飛行機
            {
                cRubber = false; cCIron = false; cCPlastic = false; airplane = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Airplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CRubber(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CCIron(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CCPlastic(Clone)").gameObject);
            }
            if (conductingWire == true && cCIron == true)//ゲーム機
            {
                conductingWire = false; cCIron = false; gameConsole = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ConductingWire(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CCIron(Clone)").gameObject);
            }
            if (cRubber == true && cCIron == true && conductingWire == true)//ラジコン
            {
                cRubber = false; cCIron = false; conductingWire = false; radiocotrolled = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Radiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CRubber(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CCIron(Clone)").gameObject);
                Destroy(gameObject.transform.Find("ConductingWire(Clone)").gameObject);
            }
            if (cCPlastic == true && conductingWire == true)//コントローラー
            {
                cCPlastic = false; conductingWire = false; controller = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Controller, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CCPlastic(Clone)").gameObject);
                Destroy(gameObject.transform.Find("ConductingWire(Clone)").gameObject);
            }
        }
        if (tYPE == WorkDesk_TYPE.desk)
        {
            if (cPaper == true && cLeather == true)//本
            {
                cPaper = false; cLeather = false; book = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Book, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CPaper(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CLeather(Clone)").gameObject);
            }
            if (cCream == true && squeezing == true)//絞りクリーム
            {
                cCream = false; squeezing = false; cCCream = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CCCream, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CCream(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Squeezing(Clone)").gameObject);
            }
            if (chocolateCream == true && squeezing == true)//絞りチョコクリーム
            {
                chocolateCream = false; squeezing = false; cChocolateCream = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CChocolateCream, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ChocolateCream(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Squeezing(Clone)").gameObject);
            }
            if (cPancake == true && cStrawberry == true && cCCream == true)//ケーキ
            {
                cPancake = false; cStrawberry = false; cCCream = false; cake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Cake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CPancake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CStrawberry(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CCCream(Clone)").gameObject);
            }
            if (cPancake == true && cStrawberry == true && cChocolateCream == true)//チョコケーキ
            {
                cPancake = false; cStrawberry = false; cChocolateCream = false; cake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Cake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CPancake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CStrawberry(Clone)").gameObject);
                Destroy(gameObject.transform.Find("CChocolateCream(Clone)").gameObject);
            }
            if (cSoft == true && gamePackage == true)//ゲームソフト
            {
                cSoft = false; gamePackage = false; software = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Software, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("CSoft(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GamePackage(Clone)").gameObject);
            }
            if (candy == true && bag == true)//キャンディ加工
            {
                candy = false; bag = false; cCandy = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(CCandy, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Candy(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Bag(Clone)").gameObject);
            }
            if (cCandy == true && chocolate == true && cookie == true && package == true)//お菓子詰め合わせ
            {
                cCandy = false; chocolate = false; cookie = false; package = false; assort = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(Assort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Candy(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Chocolate(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Cookie(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Package(Clone)").gameObject);
            }
            if (redScarf == true && pinkGift == true && ribbon == true)//ここからプレゼント
            {
                redScarf = false; pinkGift = false; ribbon = false; pinkRedScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blueScarf == true && pinkGift == true && ribbon == true)
            {
                blueScarf = false; pinkGift = false; ribbon = false; pinkBlueScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (book == true && pinkGift == true && ribbon == true)
            {
                book = false; pinkGift = false; ribbon = false; pinkBook = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (car == true && pinkGift == true && ribbon == true)
            {
                car = false; pinkGift = false; ribbon = false; pinkCar = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (airplane == true && pinkGift == true && ribbon == true)
            {
                airplane = false; pinkGift = false; ribbon = false; pinkAirplane = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (cake == true && pinkGift == true && ribbon == true)
            {
                cake = false; pinkGift = false; ribbon = false; pinkCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (chocolateCake == true && pinkGift == true && ribbon == true)
            {
                chocolateCake = false; pinkGift = false; ribbon = false; pinkChocolateCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (software == true && pinkGift == true && ribbon == true)
            {
                software = false; pinkGift = false; ribbon = false; pinkSoftware = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (gameConsole == true && pinkGift == true && ribbon == true)
            {
                gameConsole = false; pinkGift = false; ribbon = false; pinkGameConsole = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (radiocotrolled == true && pinkGift == true && ribbon == true)
            {
                radiocotrolled = false; pinkGift = false; ribbon = false; pinkRadiocotrolled = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (controller == true && pinkGift == true && ribbon == true)
            {
                controller = false; pinkGift = false; ribbon = false; pinkController = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redClothes == true && pinkGift == true && ribbon == true)
            {
                redClothes = false; pinkGift = false; ribbon = false; pinkRedClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blackClothes == true && pinkGift == true && ribbon == true)
            {
                blackClothes = false; pinkGift = false; ribbon = false; pinkBlackClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (whiteClothes == true && pinkGift == true && ribbon == true)
            {
                whiteClothes = false; pinkGift = false; ribbon = false; pinkWhiteClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (assort == true && pinkGift == true && ribbon == true)
            {
                assort = false; pinkGift = false; ribbon = false; pinkAssort = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (dool == true && pinkGift == true && ribbon == true)
            {
                dool = false; pinkGift = false; ribbon = false; pinkDool = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PinkDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redScarf == true && redGift == true && ribbon == true)//ここからプレゼント
            {
                redScarf = false; redGift = false; ribbon = false; redRedScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blueScarf == true && redGift == true && ribbon == true)
            {
                blueScarf = false; redGift = false; ribbon = false; redBlueScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (book == true && redGift == true && ribbon == true)
            {
                book = false; redGift = false; ribbon = false; redBook = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (car == true && redGift == true && ribbon == true)
            {
                car = false; redGift = false; ribbon = false; redCar = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (airplane == true && redGift == true && ribbon == true)
            {
                airplane = false; redGift = false; ribbon = false; redAirplane = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (cake == true && redGift == true && ribbon == true)
            {
                cake = false; redGift = false; ribbon = false; redCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (chocolateCake == true && redGift == true && ribbon == true)
            {
                chocolateCake = false; redGift = false; ribbon = false; redChocolateCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (software == true && redGift == true && ribbon == true)
            {
                software = false; redGift = false; ribbon = false; redSoftware = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (gameConsole == true && redGift == true && ribbon == true)
            {
                gameConsole = false; redGift = false; ribbon = false; redGameConsole = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (radiocotrolled == true && redGift == true && ribbon == true)
            {
                radiocotrolled = false; redGift = false; ribbon = false; redRadiocotrolled = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (controller == true && redGift == true && ribbon == true)
            {
                controller = false; redGift = false; ribbon = false; redController = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redClothes == true && redGift == true && ribbon == true)
            {
                redClothes = false; redGift = false; ribbon = false; redRedClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blackClothes == true && redGift == true && ribbon == true)
            {
                blackClothes = false; redGift = false; ribbon = false; redBlackClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (whiteClothes == true && redGift == true && ribbon == true)
            {
                whiteClothes = false; redGift = false; ribbon = false; redWhiteClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (assort == true && redGift == true && ribbon == true)
            {
                assort = false; redGift = false; ribbon = false; redAssort = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (dool == true && redGift == true && ribbon == true)
            {
                dool = false; redGift = false; ribbon = false; redDool = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(RedDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redScarf == true && yellowGift == true && ribbon == true)//ここからプレゼント
            {
                redScarf = false; yellowGift = false; ribbon = false; yellowRedScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blueScarf == true && yellowGift == true && ribbon == true)
            {
                blueScarf = false; yellowGift = false; ribbon = false; yellowBlueScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (book == true && yellowGift == true && ribbon == true)
            {
                book = false; yellowGift = false; ribbon = false; yellowBook = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (car == true && yellowGift == true && ribbon == true)
            {
                car = false; yellowGift = false; ribbon = false; yellowCar = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (airplane == true && yellowGift == true && ribbon == true)
            {
                airplane = false; yellowGift = false; ribbon = false; yellowAirplane = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (cake == true && yellowGift == true && ribbon == true)
            {
                cake = false; yellowGift = false; ribbon = false; yellowCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (chocolateCake == true && yellowGift == true && ribbon == true)
            {
                chocolateCake = false; yellowGift = false; ribbon = false; yellowChocolateCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (software == true && yellowGift == true && ribbon == true)
            {
                software = false; yellowGift = false; ribbon = false; yellowSoftware = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (gameConsole == true && yellowGift == true && ribbon == true)
            {
                gameConsole = false; yellowGift = false; ribbon = false; yellowGameConsole = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (radiocotrolled == true && yellowGift == true && ribbon == true)
            {
                radiocotrolled = false; yellowGift = false; ribbon = false; yellowRadiocotrolled = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (controller == true && yellowGift == true && ribbon == true)
            {
                controller = false; yellowGift = false; ribbon = false; yellowController = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redClothes == true && yellowGift == true && ribbon == true)
            {
                redClothes = false; yellowGift = false; ribbon = false; yellowRedClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blackClothes == true && yellowGift == true && ribbon == true)
            {
                blackClothes = false; yellowGift = false; ribbon = false; yellowBlackClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (whiteClothes == true && yellowGift == true && ribbon == true)
            {
                whiteClothes = false; yellowGift = false; ribbon = false; yellowWhiteClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (assort == true && yellowGift == true && ribbon == true)
            {
                assort = false; yellowGift = false; ribbon = false; yellowAssort = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (dool == true && yellowGift == true && ribbon == true)
            {
                dool = false; yellowGift = false; ribbon = false; yellowDool = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(YellowDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redScarf == true && greenGift == true && ribbon == true)//ここからプレゼント
            {
                redScarf = false; greenGift = false; ribbon = false; greenRedScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blueScarf == true && greenGift == true && ribbon == true)
            {
                blueScarf = false; greenGift = false; ribbon = false; greenBlueScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (book == true && greenGift == true && ribbon == true)
            {
                book = false; greenGift = false; ribbon = false; greenBook = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (car == true && greenGift == true && ribbon == true)
            {
                car = false; greenGift = false; ribbon = false; greenCar = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (airplane == true && greenGift == true && ribbon == true)
            {
                airplane = false; greenGift = false; ribbon = false; greenAirplane = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (cake == true && greenGift == true && ribbon == true)
            {
                cake = false; greenGift = false; ribbon = false; greenCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (chocolateCake == true && greenGift == true && ribbon == true)
            {
                chocolateCake = false; greenGift = false; ribbon = false; greenChocolateCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (software == true && greenGift == true && ribbon == true)
            {
                software = false; greenGift = false; ribbon = false; greenSoftware = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (gameConsole == true && greenGift == true && ribbon == true)
            {
                gameConsole = false; greenGift = false; ribbon = false; greenGameConsole = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (radiocotrolled == true && greenGift == true && ribbon == true)
            {
                radiocotrolled = false; greenGift = false; ribbon = false; greenRadiocotrolled = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (controller == true && greenGift == true && ribbon == true)
            {
                controller = false; greenGift = false; ribbon = false; greenController = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redClothes == true && greenGift == true && ribbon == true)
            {
                redClothes = false; greenGift = false; ribbon = false; greenRedClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blackClothes == true && greenGift == true && ribbon == true)
            {
                blackClothes = false; greenGift = false; ribbon = false; greenBlackClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (whiteClothes == true && greenGift == true && ribbon == true)
            {
                whiteClothes = false; greenGift = false; ribbon = false; greenWhiteClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (assort == true && greenGift == true && ribbon == true)
            {
                assort = false; greenGift = false; ribbon = false; greenAssort = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (dool == true && greenGift == true && ribbon == true)
            {
                dool = false; greenGift = false; ribbon = false; greenDool = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(GreenDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redScarf == true && blueGift == true && ribbon == true)//ここからプレゼント
            {
                redScarf = false; blueGift = false; ribbon = false; blueRedScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blueScarf == true && blueGift == true && ribbon == true)
            {
                blueScarf = false; blueGift = false; ribbon = false; blueBlueScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (book == true && blueGift == true && ribbon == true)
            {
                book = false; blueGift = false; ribbon = false; blueBook = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (car == true && blueGift == true && ribbon == true)
            {
                car = false; blueGift = false; ribbon = false; blueCar = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (airplane == true && blueGift == true && ribbon == true)
            {
                airplane = false; blueGift = false; ribbon = false; blueAirplane = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (cake == true && blueGift == true && ribbon == true)
            {
                cake = false; blueGift = false; ribbon = false; blueCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (chocolateCake == true && blueGift == true && ribbon == true)
            {
                chocolateCake = false; blueGift = false; ribbon = false; blueChocolateCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (software == true && blueGift == true && ribbon == true)
            {
                software = false; blueGift = false; ribbon = false; blueSoftware = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (gameConsole == true && blueGift == true && ribbon == true)
            {
                gameConsole = false; blueGift = false; ribbon = false; blueGameConsole = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (radiocotrolled == true && blueGift == true && ribbon == true)
            {
                radiocotrolled = false; blueGift = false; ribbon = false; blueRadiocotrolled = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (controller == true && blueGift == true && ribbon == true)
            {
                controller = false; blueGift = false; ribbon = false; blueController = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redClothes == true && blueGift == true && ribbon == true)
            {
                redClothes = false; blueGift = false; ribbon = false; blueRedClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blackClothes == true && blueGift == true && ribbon == true)
            {
                blackClothes = false; blueGift = false; ribbon = false; blueBlackClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (whiteClothes == true && blueGift == true && ribbon == true)
            {
                whiteClothes = false; blueGift = false; ribbon = false; blueWhiteClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (assort == true && blueGift == true && ribbon == true)
            {
                assort = false; blueGift = false; ribbon = false; blueAssort = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (dool == true && blueGift == true && ribbon == true)
            {
                dool = false; blueGift = false; ribbon = false; blueDool = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(BlueDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redScarf == true && purpleGift == true && ribbon == true)//ここからプレゼント
            {
                redScarf = false; purpleGift = false; ribbon = false; purpleRedScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleRedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blueScarf == true && purpleGift == true && ribbon == true)
            {
                blueScarf = false; purpleGift = false; ribbon = false; purpleBlueScarf = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleBlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (book == true && purpleGift == true && ribbon == true)
            {
                book = false; purpleGift = false; ribbon = false; purpleBook = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleBook, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (car == true && purpleGift == true && ribbon == true)
            {
                car = false; purpleGift = false; ribbon = false; purpleCar = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleCar, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (airplane == true && purpleGift == true && ribbon == true)
            {
                airplane = false; purpleGift = false; ribbon = false; purpleAirplane = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleAirplane, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (cake == true && purpleGift == true && ribbon == true)
            {
                cake = false; purpleGift = false; ribbon = false; purpleCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (chocolateCake == true && purpleGift == true && ribbon == true)
            {
                chocolateCake = false; purpleGift = false; ribbon = false; purpleChocolateCake = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleChocolateCake, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (software == true && purpleGift == true && ribbon == true)
            {
                software = false; purpleGift = false; ribbon = false; purpleSoftware = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleSoftware, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (gameConsole == true && purpleGift == true && ribbon == true)
            {
                gameConsole = false; purpleGift = false; ribbon = false; purpleGameConsole = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleGameConsole, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (radiocotrolled == true && purpleGift == true && ribbon == true)
            {
                radiocotrolled = false; purpleGift = false; ribbon = false; purpleRadiocotrolled = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleRadiocotrolled, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (controller == true && purpleGift == true && ribbon == true)
            {
                controller = false; purpleGift = false; ribbon = false; purpleController = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleController, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (redClothes == true && purpleGift == true && ribbon == true)
            {
                redClothes = false; purpleGift = false; ribbon = false; purpleRedClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleRedClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (blackClothes == true && purpleGift == true && ribbon == true)
            {
                blackClothes = false; purpleGift = false; ribbon = false; purpleBlackClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleBlackClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (whiteClothes == true && purpleGift == true && ribbon == true)
            {
                whiteClothes = false; purpleGift = false; ribbon = false; purpleWhiteClothes = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleWhiteClothes, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (assort == true && purpleGift == true && ribbon == true)
            {
                assort = false; purpleGift = false; ribbon = false; purpleAssort = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleAssort, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
            if (dool == true && purpleGift == true && ribbon == true)
            {
                dool = false; purpleGift = false; ribbon = false; purpleDool = true; canwork = true; IHaveItem = 1;
                //UIにゲージの開始を伝える
                var parent = this.transform;
                Instantiate(PurpleDool, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
            }
        }
        return canwork;
    }
    public void workGet(int playernumber)
    {
        if (redWool == true && IHaveItem == 1)
        {
            Debug.Log("成功");
            if (playernumber == 1)
            {
                //Debug.Log("ダイ成功");
                //FindObjectOfType<PlayerDirector>().GetItem("RedWool", 1);
                //Destroy(gameObject.transform.Find("RedWool(Clone)").gameObject);
                //setFalse();
                return;
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedWool", 2);
                //Destroy(gameObject.transform.Find("RedWool(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueWool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueWool", 1);
                Destroy(gameObject.transform.Find("BlueWool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueWool", 2);
                Destroy(gameObject.transform.Find("BlueWool(Clone)").gameObject);
                setFalse();
            }
        }
        if (paper == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Paper", 1);
                Destroy(gameObject.transform.Find("Paper(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Paper", 2);
                Destroy(gameObject.transform.Find("Paper(Clone)").gameObject);
                setFalse();
            }
        }
        if (leather == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Leather", 1);
                Destroy(gameObject.transform.Find("Leather(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Leather", 2);
                Destroy(gameObject.transform.Find("Leather(Clone)").gameObject);
                setFalse();
            }
        }
        if (iron == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Iron", 1);
                Destroy(gameObject.transform.Find("Iron(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Iron", 2);
                Destroy(gameObject.transform.Find("Iron(Clone)").gameObject);
                setFalse();
            }
        }
        if (rubber == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Rubber", 1);
                Destroy(gameObject.transform.Find("Rubber(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Rubber", 2);
                Destroy(gameObject.transform.Find("Rubber(Clone)").gameObject);
                setFalse();
            }
        }
        if (plastic == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Plastic", 1);
                Destroy(gameObject.transform.Find("Plastic(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Plastic", 2);
                Destroy(gameObject.transform.Find("Plastic(Clone)").gameObject);
                setFalse();
            }
        }
        if (pancake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Pancake", 1);
                Destroy(gameObject.transform.Find("Pancake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Pancake", 2);
                Destroy(gameObject.transform.Find("Pancake(Clone)").gameObject);
                setFalse();
            }
        }
        if (cream == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cream", 1);
                Destroy(gameObject.transform.Find("Cream(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cream", 2);
                Destroy(gameObject.transform.Find("Cream(Clone)").gameObject);
                setFalse();
            }
        }
        if (chocolateCream == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("ChocolateCream", 1);
                Destroy(gameObject.transform.Find("ChocolateCream(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("ChocolateCream", 2);
                Destroy(gameObject.transform.Find("ChocolateCream(Clone)").gameObject);
                setFalse();
            }
        }
        if (strawberry == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Strawberry", 1);
                Destroy(gameObject.transform.Find("Strawberry(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Strawberry", 2);
                Destroy(gameObject.transform.Find("Strawberry(Clone)").gameObject);
                setFalse();
            }
        }
        if (conductingWire == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("ConductingWire", 1);
                Destroy(gameObject.transform.Find("ConductingWire(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("ConductingWire", 2);
                Destroy(gameObject.transform.Find("ConductingWire(Clone)").gameObject);
                setFalse();
            }
        }
        if (package == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Package", 1); 
                Destroy(gameObject.transform.Find("Package(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Package", 2);
                Destroy(gameObject.transform.Find("Package(Clone)").gameObject);
                setFalse();
            }
        }
        if (candy == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Candy", 1);
                Destroy(gameObject.transform.Find("Candy(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Candy", 2);
                Destroy(gameObject.transform.Find("Candy(Clone)").gameObject);
                setFalse();
            }
        }
        if (cookie == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cookie", 1);
                Destroy(gameObject.transform.Find("Cookie(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cookie", 2);
                Destroy(gameObject.transform.Find("Cookie(Clone)").gameObject);
                setFalse();
            }
        }
        if (redCloth == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedCloth", 1);
                Destroy(gameObject.transform.Find("RedCloth(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedCloth", 2);
                Destroy(gameObject.transform.Find("RedCloth(Clone)").gameObject);
                setFalse();
            }
        }
        if (blackCloth == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlackCloth", 1);
                Destroy(gameObject.transform.Find("BlackCloth(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlackCloth", 2);
                Destroy(gameObject.transform.Find("BlackCloth(Clone)").gameObject);
                setFalse();
            }
        }
        if (whiteCloth == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("WhiteCloth", 1);
                Destroy(gameObject.transform.Find("WhiteCloth(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("WhiteCloth", 2);
                Destroy(gameObject.transform.Find("WhiteCloth(Clone)").gameObject);
                setFalse();
            }
        }
        if (cSoft == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CSoft", 1);
                Destroy(gameObject.transform.Find("CSoft(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CSoft", 2);
                Destroy(gameObject.transform.Find("CSoft(Clone)").gameObject);
                setFalse();
            }
        }
        if (gamePackage == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GamePackage", 1);
                Destroy(gameObject.transform.Find("GamePackage(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GamePackage", 2);
                Destroy(gameObject.transform.Find("GamePackage(Clone)").gameObject);
                setFalse();
            }
        }
        if (cotton == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cotton", 1);
                Destroy(gameObject.transform.Find("Cotton(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cotton", 2);
                Destroy(gameObject.transform.Find("Cotton(Clone)").gameObject);
                setFalse();
            }
        }
        if (cloth == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cloth", 1);
                Destroy(gameObject.transform.Find("Cloth(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cloth", 2);
                Destroy(gameObject.transform.Find("Cloth(Clone)").gameObject);
                setFalse();
            }
        }
        if (ribbon == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Ribbon", 1);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Ribbon", 2);
                Destroy(gameObject.transform.Find("Ribbon(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkGift == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkGift", 1);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkGift", 2);
                Destroy(gameObject.transform.Find("PinkGift(Clone)").gameObject);
                setFalse();
            }
        }
        if (redGift == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedGift", 1);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedGift", 2);
                Destroy(gameObject.transform.Find("RedGift(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowGift == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowGift", 1);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowGift", 2);
                Destroy(gameObject.transform.Find("YellowGift(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenGift == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenGift", 1);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenGift", 2);
                Destroy(gameObject.transform.Find("GreenGift(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueGift == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueGift", 1);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueGift", 2);
                Destroy(gameObject.transform.Find("BlueGift(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleGift == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleGift", 1);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);

                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleGift", 2);
                Destroy(gameObject.transform.Find("PurpleGift(Clone)").gameObject);
                setFalse();
            }
        }
        if (redScarf == true && IHaveItem == 1)
        {
            Debug.Log("ared");
            if (playernumber == 1)
            {
                Debug.Log("aared");
                FindObjectOfType<PlayerDirector>().GetItem("RedScarf", 1);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedScarf", 2);
                Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueScarf", 1);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueScarf", 2);
                Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (book == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Book", 1);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Book", 2);
                Destroy(gameObject.transform.Find("Book(Clone)").gameObject);
                setFalse();
            }
        }
        if (car == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Car", 1);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Car", 2);
                Destroy(gameObject.transform.Find("Car(Clone)").gameObject);

                setFalse();
            }
        }
        if (airplane == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Airplane", 1);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Airplane", 2);
                Destroy(gameObject.transform.Find("Airplane(Clone)").gameObject);
                setFalse();
            }
        }
        if (cake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cake", 1);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Cake", 2);
                Destroy(gameObject.transform.Find("Cake(Clone)").gameObject);
                setFalse();
            }
        }
        if (chocolateCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("ChocolateCake", 1);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("ChocolateCake", 2);
                Destroy(gameObject.transform.Find("ChocolateCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (gameConsole == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GameConsole", 1);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GameConsole", 2);
                Destroy(gameObject.transform.Find("GameConsole(Clone)").gameObject);
                setFalse();
            }
        }
        if (software == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Software", 1);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Software", 2);
                Destroy(gameObject.transform.Find("Software(Clone)").gameObject);
                setFalse();
            }
        }
        if (assort == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Assort", 1);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Assort", 2);
                Destroy(gameObject.transform.Find("Assort(Clone)").gameObject);
                setFalse();
            }
        }
        if (robot == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Robot", 1);
                Destroy(gameObject.transform.Find("Robot(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Robot", 2);
                Destroy(gameObject.transform.Find("Robot(Clone)").gameObject);
                setFalse();
            }
        }
        if (radiocotrolled == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Radiocotrolled", 1);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Radiocotrolled", 2);
                Destroy(gameObject.transform.Find("Radiocotrolled(Clone)").gameObject);
                setFalse();
            }
        }
        if (dool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Dool", 1);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Dool", 2);
                Destroy(gameObject.transform.Find("Dool(Clone)").gameObject);
                setFalse();
            }
        }
        if (redClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedClothes", 1);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedClothes", 2);
                Destroy(gameObject.transform.Find("RedClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (blackClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlackClothes", 1);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlackClothes", 2);
                Destroy(gameObject.transform.Find("BlackClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (whiteClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("WhiteClothes", 1);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("WhiteClothes", 2);
                Destroy(gameObject.transform.Find("WhiteClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkRedScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRedScarf", 1);
                Destroy(gameObject.transform.Find("PinkRedScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRedScarf", 2);
                Destroy(gameObject.transform.Find("PinkRedScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkBlueScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkBlueScarf", 1);
                Destroy(gameObject.transform.Find("PinkBlueScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkBlueScarf", 2);
                Destroy(gameObject.transform.Find("PinkBlueScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkBook == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkBook", 1);
                Destroy(gameObject.transform.Find("PinkBook(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkBook", 2);
                Destroy(gameObject.transform.Find("PinkBook(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkCar == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkCar", 1);
                Destroy(gameObject.transform.Find("PinkCar(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkCar", 2);
                Destroy(gameObject.transform.Find("PinkCar(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkAirplane == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                setFalse();
                FindObjectOfType<PlayerDirector>().GetItem("PinkAirplane", 1);
                Destroy(gameObject.transform.Find("PinkAirplane(Clone)").gameObject);
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkAirplane", 2);
                Destroy(gameObject.transform.Find("PinkAirplane(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkCake", 1);
                Destroy(gameObject.transform.Find("PinkCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkCake", 2);
                Destroy(gameObject.transform.Find("PinkCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkChocolateCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkChocolateCake", 1);
                Destroy(gameObject.transform.Find("PinkChocolateCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkChocolateCake", 2);
                Destroy(gameObject.transform.Find("PinkChocolateCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkGameConsole == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkGameConsole", 1);
                Destroy(gameObject.transform.Find("PinkGameConsole(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkGameConsole", 2);
                Destroy(gameObject.transform.Find("PinkGameConsole(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkSoftware == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkSoftware", 1);
                Destroy(gameObject.transform.Find("PinkSoftware(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkSoftware", 2);
                Destroy(gameObject.transform.Find("PinkSoftware(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkAssort == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkAssort", 1);
                Destroy(gameObject.transform.Find("PinkAssort(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkAssort", 2);
                Destroy(gameObject.transform.Find("PinkAssort(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkRobot == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRobot", 1);
                Destroy(gameObject.transform.Find("PinkRobot(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRobot", 2);
                Destroy(gameObject.transform.Find("PinkRobot(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkRadiocotrolled == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRadiocotrolled", 1);
                Destroy(gameObject.transform.Find("PinkRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRadiocotrolled", 2);
                Destroy(gameObject.transform.Find("PinkRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkDool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkDool", 1);
                Destroy(gameObject.transform.Find("PinkDool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkDool", 2);
                Destroy(gameObject.transform.Find("PinkDool(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkRedClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRedClothes", 1);
                Destroy(gameObject.transform.Find("PinkRedClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkRedClothes", 2);
                Destroy(gameObject.transform.Find("PinkRedClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkBlackClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkBlackClothes", 1);
                Destroy(gameObject.transform.Find("PinkBlackClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkBlackClothes", 2);
                Destroy(gameObject.transform.Find("PinkBlackClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkWhiteClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkWhiteClothes", 1);
                Destroy(gameObject.transform.Find("PinkWhiteClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkWhiteClothes", 2);
                Destroy(gameObject.transform.Find("PinkWhiteClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (redRedScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRedScarf", 1);
                Destroy(gameObject.transform.Find("RedRedScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRedScarf", 2);
                Destroy(gameObject.transform.Find("RedRedScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (redBlueScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedBlueScarf", 1);
                Destroy(gameObject.transform.Find("RedBlueScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedBlueScarf", 2);
                Destroy(gameObject.transform.Find("RedBlueScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (redBook == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedBook", 1);
                Destroy(gameObject.transform.Find("RedBook(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedBook", 2);
                Destroy(gameObject.transform.Find("RedBook(Clone)").gameObject);
                setFalse();
            }
        }
        if (redCar == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedCar", 1);
                Destroy(gameObject.transform.Find("RedCar(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedCar", 2);
                Destroy(gameObject.transform.Find("RedCar(Clone)").gameObject);
                setFalse();
            }
        }
        if (redAirplane == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedAirplane", 1);
                Destroy(gameObject.transform.Find("RedAirplane(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedAirplane", 2);
                Destroy(gameObject.transform.Find("RedAirplane(Clone)").gameObject);
                setFalse();
            }
        }
        if (redCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedCake", 1);
                Destroy(gameObject.transform.Find("RedCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedCake", 2);
                Destroy(gameObject.transform.Find("RedCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (redChocolateCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedChocolateCake", 1);
                Destroy(gameObject.transform.Find("RedChocolateCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedChocolateCake", 2);
                Destroy(gameObject.transform.Find("RedChocolateCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (redGameConsole == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedGameConsole", 1);
                Destroy(gameObject.transform.Find("RedGameConsole(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedGameConsole", 2);
                Destroy(gameObject.transform.Find("RedGameConsole(Clone)").gameObject);
                setFalse();
            }
        }
        if (redSoftware == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedSoftware", 1);
                Destroy(gameObject.transform.Find("RedSoftware(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedSoftware", 2);
                Destroy(gameObject.transform.Find("RedSoftware(Clone)").gameObject);
                setFalse();
            }
        }
        if (redAssort == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedAssort", 1);
                Destroy(gameObject.transform.Find("RedAssort(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedAssort", 2);
                Destroy(gameObject.transform.Find("RedAssort(Clone)").gameObject);
                setFalse();
            }
        }
        if (redRobot == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRobot", 1);
                Destroy(gameObject.transform.Find("RedRobot(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRobot", 2);
                Destroy(gameObject.transform.Find("RedRobot(Clone)").gameObject);
                setFalse();
            }
        }
        if (redRadiocotrolled == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRadiocotrolled", 1);
                Destroy(gameObject.transform.Find("RedRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRadiocotrolled", 2);
                Destroy(gameObject.transform.Find("RedRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
        }
        if (redDool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedDool", 1);
                Destroy(gameObject.transform.Find("RedDool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedDool", 2);
                Destroy(gameObject.transform.Find("RedDool(Clone)").gameObject);
                setFalse();
            }
        }
        if (redRedClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRedClothes", 1);
                Destroy(gameObject.transform.Find("RedRedClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedRedClothes", 2);
                Destroy(gameObject.transform.Find("RedRedClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (redBlackClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedBlackClothes", 1);
                Destroy(gameObject.transform.Find("RedBlackClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedBlackClothes", 2);
                Destroy(gameObject.transform.Find("RedBlackClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (redWhiteClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedWhiteClothes", 1);
                Destroy(gameObject.transform.Find("RedWhiteClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedWhiteClothes", 2);
                Destroy(gameObject.transform.Find("RedWhiteClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowRedScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRedScarf", 1);
                Destroy(gameObject.transform.Find("YellowRedScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRedScarf", 2);
                Destroy(gameObject.transform.Find("YellowRedScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowBlueScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowBlueScarf", 1);
                Destroy(gameObject.transform.Find("YellowBlueScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowBlueScarf", 2);
                Destroy(gameObject.transform.Find("YellowBlueScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowBook == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowBook", 1);
                Destroy(gameObject.transform.Find("YellowBook(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowBook", 2);
                Destroy(gameObject.transform.Find("YellowBook(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowCar == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowCar", 1);
                Destroy(gameObject.transform.Find("YellowCar(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowCar", 2);
                Destroy(gameObject.transform.Find("YellowCar(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowAirplane == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowAirplane", 1);
                Destroy(gameObject.transform.Find("YellowAirplane(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowAirplane", 2);
                Destroy(gameObject.transform.Find("YellowAirplane(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowCake", 1);
                Destroy(gameObject.transform.Find("YellowCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowCake", 2);
                Destroy(gameObject.transform.Find("YellowCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowChocolateCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowChocolateCake", 1);
                Destroy(gameObject.transform.Find("YellowChocolateCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowChocolateCake", 2);
                Destroy(gameObject.transform.Find("YellowChocolateCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowGameConsole == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowGameConsole", 1);
                Destroy(gameObject.transform.Find("YellowGameConsole(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowGameConsole", 2);
                Destroy(gameObject.transform.Find("YellowGameConsole(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowSoftware == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowSoftware", 1);
                Destroy(gameObject.transform.Find("YellowSoftware(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowSoftware", 2);
                Destroy(gameObject.transform.Find("YellowSoftware(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowAssort == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowAssort", 1);
                Destroy(gameObject.transform.Find("YellowAssort(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowAssort", 2);
                Destroy(gameObject.transform.Find("YellowAssort(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowRobot == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRobot", 1);
                Destroy(gameObject.transform.Find("YellowRobot(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRobot", 2);
                Destroy(gameObject.transform.Find("YellowRobot(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowRadiocotrolled == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRadiocotrolled", 1);
                Destroy(gameObject.transform.Find("YellowRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRadiocotrolled", 2);
                Destroy(gameObject.transform.Find("YellowRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowDool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowDool", 1);
                Destroy(gameObject.transform.Find("YellowDool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowDool", 2);
                Destroy(gameObject.transform.Find("YellowDool(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowRedClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRedClothes", 1);
                Destroy(gameObject.transform.Find("YellowRedClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowRedClothes", 2);
                Destroy(gameObject.transform.Find("YellowRedClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowBlackClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowBlackClothes", 1);
                Destroy(gameObject.transform.Find("YellowBlackClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowBlackClothes", 2);
                Destroy(gameObject.transform.Find("YellowBlackClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowWhiteClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowWhiteClothes", 1);
                Destroy(gameObject.transform.Find("YellowWhiteClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowWhiteClothes", 2);
                Destroy(gameObject.transform.Find("YellowWhiteClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenRedScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRedScarf", 1);
                Destroy(gameObject.transform.Find("GreenRedScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRedScarf", 2);
                Destroy(gameObject.transform.Find("GreenRedScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenBlueScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenBlueScarf", 1);
                Destroy(gameObject.transform.Find("GreenBlueScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenBlueScarf", 2);
                Destroy(gameObject.transform.Find("GreenBlueScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenBook == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenBook", 1);
                Destroy(gameObject.transform.Find("GreenBook(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenBook", 2);
                Destroy(gameObject.transform.Find("GreenBook(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenCar == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenCar", 1);
                Destroy(gameObject.transform.Find("GreenCar(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenCar", 2);
                Destroy(gameObject.transform.Find("GreenCar(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenAirplane == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenAirplane", 1);
                Destroy(gameObject.transform.Find("GreenAirplane(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenAirplane", 2);
                Destroy(gameObject.transform.Find("GreenAirplane(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenCake", 1);
                Destroy(gameObject.transform.Find("GreenCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenCake", 2);
                Destroy(gameObject.transform.Find("GreenCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenChocolateCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenChocolateCake", 1);
                Destroy(gameObject.transform.Find("GreenChocolateCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenChocolateCake", 2);
                Destroy(gameObject.transform.Find("GreenChocolateCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenGameConsole == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenGameConsole", 1);
                Destroy(gameObject.transform.Find("GreenGameConsole(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenGameConsole", 2);
                Destroy(gameObject.transform.Find("GreenGameConsole(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenSoftware == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenSoftware", 1);
                Destroy(gameObject.transform.Find("GreenSoftware(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenSoftware", 2);
                Destroy(gameObject.transform.Find("GreenSoftware(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenAssort == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenAssort", 1);
                Destroy(gameObject.transform.Find("GreenAssort(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenAssort", 2);
                Destroy(gameObject.transform.Find("GreenAssort(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenRobot == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRobot", 1);
                Destroy(gameObject.transform.Find("GreenRobot(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRobot", 2);
                Destroy(gameObject.transform.Find("GreenRobot(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenRadiocotrolled == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRadiocotrolled", 1);
                Destroy(gameObject.transform.Find("GreenRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRadiocotrolled", 2);
                Destroy(gameObject.transform.Find("GreenRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenDool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenDool", 1);
                Destroy(gameObject.transform.Find("GreenDool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenDool", 2);
                Destroy(gameObject.transform.Find("GreenDool(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenRedClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRedClothes", 1);
                Destroy(gameObject.transform.Find("GreenRedClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenRedClothes", 2);
                Destroy(gameObject.transform.Find("GreenRedClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenBlackClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenBlackClothes", 1);
                Destroy(gameObject.transform.Find("GreenBlackClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenBlackClothes", 2);
                Destroy(gameObject.transform.Find("GreenBlackClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenWhiteClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenWhiteClothes", 1);
                Destroy(gameObject.transform.Find("GreenWhiteClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenWhiteClothes", 2);
                Destroy(gameObject.transform.Find("GreenWhiteClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueRedScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRedScarf", 1);
                Destroy(gameObject.transform.Find("BlueRedScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRedScarf", 2);
                Destroy(gameObject.transform.Find("BlueRedScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueBlueScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueBlueScarf", 1);
                Destroy(gameObject.transform.Find("BlueBlueScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueBlueScarf", 2);
                Destroy(gameObject.transform.Find("BlueBlueScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueBook == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueBook", 1);
                Destroy(gameObject.transform.Find("BlueBook(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueBook", 2);
                Destroy(gameObject.transform.Find("BlueBook(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueCar == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueCar", 1);
                Destroy(gameObject.transform.Find("BlueCar(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueCar", 2);
                Destroy(gameObject.transform.Find("BlueCar(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueAirplane == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueAirplane", 1);
                Destroy(gameObject.transform.Find("BlueAirplane(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueAirplane", 2);
                Destroy(gameObject.transform.Find("BlueAirplane(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueCake", 1);
                Destroy(gameObject.transform.Find("BlueCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueCake", 2);
                Destroy(gameObject.transform.Find("BlueCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueChocolateCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueChocolateCake", 1);
                Destroy(gameObject.transform.Find("BlueChocolateCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueChocolateCake", 2);
                Destroy(gameObject.transform.Find("BlueChocolateCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueGameConsole == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueGameConsole", 1);
                Destroy(gameObject.transform.Find("BlueGameConsole(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueGameConsole", 2);
                Destroy(gameObject.transform.Find("BlueGameConsole(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueSoftware == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueSoftware", 1);
                Destroy(gameObject.transform.Find("BlueSoftware(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueSoftware", 2);
                Destroy(gameObject.transform.Find("BlueSoftware(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueAssort == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueAssort", 1);
                Destroy(gameObject.transform.Find("BlueAssort(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueAssort", 2);
                Destroy(gameObject.transform.Find("BlueAssort(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueRobot == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRobot", 1);
                Destroy(gameObject.transform.Find("BlueRobot(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRobot", 2);
                Destroy(gameObject.transform.Find("BlueRobot(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueRadiocotrolled == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRadiocotrolled", 1);
                Destroy(gameObject.transform.Find("BlueRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRadiocotrolled", 2);
                Destroy(gameObject.transform.Find("BlueRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueDool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueDool", 1);
                Destroy(gameObject.transform.Find("BlueDool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueDool", 2);
                Destroy(gameObject.transform.Find("BlueDool(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueRedClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRedClothes", 1);
                Destroy(gameObject.transform.Find("BlueRedClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueRedClothes", 2);
                Destroy(gameObject.transform.Find("BlueRedClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueBlackClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueBlackClothes", 1);
                Destroy(gameObject.transform.Find("BlueBlackClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueBlackClothes", 2);
                Destroy(gameObject.transform.Find("BlueBlackClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueWhiteClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueWhiteClothes", 1);
                Destroy(gameObject.transform.Find("BlueWhiteClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueWhiteClothes", 2);
                Destroy(gameObject.transform.Find("BlueWhiteClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleRedScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRedScarf", 1);
                Destroy(gameObject.transform.Find("PurpleRedScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRedScarf", 2);
                Destroy(gameObject.transform.Find("PurpleRedScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleBlueScarf == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleBlueScarf", 1);
                Destroy(gameObject.transform.Find("PurpleBlueScarf(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleBlueScarf", 2);
                Destroy(gameObject.transform.Find("PurpleBlueScarf(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleBook == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleBook", 1);
                Destroy(gameObject.transform.Find("PurpleBook(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleBook", 2);
                Destroy(gameObject.transform.Find("PurpleBook(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleCar == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleCar", 1);
                Destroy(gameObject.transform.Find("PurpleCar(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleCar", 2);
                Destroy(gameObject.transform.Find("PurpleCar(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleAirplane == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleAirplane", 1);
                Destroy(gameObject.transform.Find("PurpleAirplane(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleAirplane", 2);
                Destroy(gameObject.transform.Find("PurpleAirplane(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleCake", 1);
                Destroy(gameObject.transform.Find("PurpleCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleCake", 2);
                Destroy(gameObject.transform.Find("PurpleCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleChocolateCake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleChocolateCake", 1);
                Destroy(gameObject.transform.Find("PurpleChocolateCake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleChocolateCake", 2);
                Destroy(gameObject.transform.Find("PurpleChocolateCake(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleGameConsole == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleGameConsole", 1);
                Destroy(gameObject.transform.Find("PurpleGameConsole(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleGameConsole", 2);
                Destroy(gameObject.transform.Find("PurpleGameConsole(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleSoftware == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleSoftware", 1);
                Destroy(gameObject.transform.Find("PurpleSoftware(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleSoftware", 2);
                Destroy(gameObject.transform.Find("PurpleSoftware(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleAssort == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleAssort", 1);
                Destroy(gameObject.transform.Find("PurpleAssort(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleAssort", 2);
                Destroy(gameObject.transform.Find("PurpleAssort(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleRobot == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                setFalse();
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRobot", 1);
                Destroy(gameObject.transform.Find("PurpleRobot(Clone)").gameObject);
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRobot", 2);
                Destroy(gameObject.transform.Find("PurpleRobot(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleRadiocotrolled == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRadiocotrolled", 1);
                Destroy(gameObject.transform.Find("PurpleRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRadiocotrolled", 2);
                Destroy(gameObject.transform.Find("PurpleRadiocotrolled(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleDool == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleDool", 1);
                Destroy(gameObject.transform.Find("PurpleDool(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleDool", 2);
                Destroy(gameObject.transform.Find("PurpleDool(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleRedClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRedClothes", 1);
                Destroy(gameObject.transform.Find("PurpleRedClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleRedClothes", 2);
                Destroy(gameObject.transform.Find("PurpleRedClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleBlackClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleBlackClothes", 1);
                Destroy(gameObject.transform.Find("PurpleBlackClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleBlackClothes", 2);
                Destroy(gameObject.transform.Find("PurpleBlackClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleWhiteClothes == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleWhiteClothes", 1);
                Destroy(gameObject.transform.Find("PurpleWhiteClothes(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleWhiteClothes", 2);
                Destroy(gameObject.transform.Find("PurpleWhiteClothes(Clone)").gameObject);
                setFalse();
            }
        }
        if (sugar == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Sugar", 1);
                Destroy(gameObject.transform.Find("Sugar(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Sugar", 2);
                Destroy(gameObject.transform.Find("Sugar(Clone)").gameObject);
                setFalse();
            }
        }
        if (water == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Water", 1);
                Destroy(gameObject.transform.Find("Water(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Water", 2);
                Destroy(gameObject.transform.Find("Water(Clone)").gameObject);
                setFalse();
            }
        }
        if (cCream == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCream", 1);
                Destroy(gameObject.transform.Find("CCream(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCream", 2);
                Destroy(gameObject.transform.Find("CCream(Clone)").gameObject);
                setFalse();
            }
        }
        if (Egg == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Egg", 1);
                Destroy(gameObject.transform.Find("Egg(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Egg", 2);
                Destroy(gameObject.transform.Find("Egg(Clone)").gameObject);
                setFalse();
            }
        }
        if (cChocolate == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CChocolate", 1);
                Destroy(gameObject.transform.Find("CChocolate(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CChocolate", 2);
                Destroy(gameObject.transform.Find("CChocolate(Clone)").gameObject);
                setFalse();
            }
        }
        if (cIron == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CIron", 1);
                Destroy(gameObject.transform.Find("CIron(Clone)").gameObject);
                setFalse();
                CancelInvoke("MissIron");
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CIron", 2);
                Destroy(gameObject.transform.Find("CIron(Clone)").gameObject);
                setFalse();
                CancelInvoke("MissIron");
            }
        }
        if (cPlastic == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CPlastic", 1);
                Destroy(gameObject.transform.Find("CPlastic(Clone)").gameObject);
                setFalse();
                CancelInvoke("MissPlastic");
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CPlastic", 2);
                Destroy(gameObject.transform.Find("CPlastic(Clone)").gameObject);
                setFalse();
                CancelInvoke("MissPlastic");
            }
        }
        if (cRubber == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CRubber", 1);
                Destroy(gameObject.transform.Find("CRubber(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CRubber", 2);
                Destroy(gameObject.transform.Find("CRubber(Clone)").gameObject);
                setFalse();
            }
        }
        if (cCIron == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCIron", 1);
                Destroy(gameObject.transform.Find("CCIron(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCIron", 2);
                Destroy(gameObject.transform.Find("CCIron(Clone)").gameObject);
                setFalse();
            }
        }
        if (cCPlastic == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCPlastic", 1);
                Destroy(gameObject.transform.Find("CCPlastic(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCPlastic", 2);
                Destroy(gameObject.transform.Find("CCPlastic(Clone)").gameObject);
                setFalse();
            }
        }
        if (controller == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Controller", 1);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Controller", 2);
                Destroy(gameObject.transform.Find("Controller(Clone)").gameObject);
                setFalse();
            }
        }
        if (cPaper == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CPaper", 1);
                Destroy(gameObject.transform.Find("CPaper(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CPaper", 2);
                Destroy(gameObject.transform.Find("CPaper(Clone)").gameObject);
                setFalse();
            }
        }
        if (cLeather == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CLeather", 1);
                Destroy(gameObject.transform.Find("CLeather(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CLeather", 2);
                Destroy(gameObject.transform.Find("CLeather(Clone)").gameObject);
                setFalse();
            }
        }
        if (cStrawberry == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CStrawberry", 1);
                Destroy(gameObject.transform.Find("CStrawberry(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CStrawberry", 2);
                Destroy(gameObject.transform.Find("CStrawberry(Clone)").gameObject);
                setFalse();
            }
        }
        if (cPancake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CPancake", 1);
                Destroy(gameObject.transform.Find("CPancake(Clone)").gameObject);
                setFalse();
                CancelInvoke("MissPancake");
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CPancake", 2);
                Destroy(gameObject.transform.Find("CPancake(Clone)").gameObject);
                setFalse();
                CancelInvoke("MissPancake");
            }
        }
        if (bag == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Bag", 1);
                Destroy(gameObject.transform.Find("Bag(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Bag", 2);
                Destroy(gameObject.transform.Find("Bag(Clone)").gameObject);
                setFalse();
            }
        }
        if (cCandy == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCandy", 1);
                Destroy(gameObject.transform.Find("CCandy(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCandy", 2);
                Destroy(gameObject.transform.Find("CCandy(Clone)").gameObject);
                setFalse();
            }
        }
        if (pinkController == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkController", 1);
                Destroy(gameObject.transform.Find("PinkController(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PinkController", 2);
                Destroy(gameObject.transform.Find("PinkController(Clone)").gameObject);
                setFalse();
            }
        }
        if (redController == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedController", 1);
                Destroy(gameObject.transform.Find("RedController(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("RedController", 2);
                Destroy(gameObject.transform.Find("RedController(Clone)").gameObject);
                setFalse();
            }
        }
        if (yellowController == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowController", 1);
                Destroy(gameObject.transform.Find("YellowController(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("YellowController", 2);
                Destroy(gameObject.transform.Find("YellowController(Clone)").gameObject);
                setFalse();
            }
        }
        if (greenController == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenController", 1);
                Destroy(gameObject.transform.Find("GreenController(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("GreenController", 2);
                Destroy(gameObject.transform.Find("GreenController(Clone)").gameObject);
                setFalse();
            }
        }
        if (blueController == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueController", 1);
                Destroy(gameObject.transform.Find("BlueController(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("BlueController", 2);
                Destroy(gameObject.transform.Find("BlueController(Clone)").gameObject);
                setFalse();
            }
        }
        if (purpleController == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleController", 1);
                Destroy(gameObject.transform.Find("PurpleController(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("PurpleController", 2);
                Destroy(gameObject.transform.Find("PurpleController(Clone)").gameObject);
                setFalse();
            }
        }
        if (squeezing == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Squeezing", 1);
                Destroy(gameObject.transform.Find("Squeezing(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("Squeezing", 2);
                Destroy(gameObject.transform.Find("Squeezing(Clone)").gameObject);
                setFalse();
            }
        }
        if (cCCream == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCCream", 1);
                Destroy(gameObject.transform.Find("CCCream(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CCCream", 2);
                Destroy(gameObject.transform.Find("CCCream(Clone)").gameObject);
                setFalse();
            }
        }
        if (cChocolateCream == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CChocolateCream", 1);
                Destroy(gameObject.transform.Find("CChocolateCream(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("CChocolateCream", 2);
                Destroy(gameObject.transform.Find("CChocolateCream(Clone)").gameObject);
                setFalse();
            }
        }
        if (mIron == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("MIron", 1);
                Destroy(gameObject.transform.Find("MIron(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("MIron", 2);
                Destroy(gameObject.transform.Find("MIron(Clone)").gameObject);
                setFalse();
            }
        }
        if (mPlastic == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("MPlastic", 1);
                Destroy(gameObject.transform.Find("MPlastic(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("MPlastic", 2);
                Destroy(gameObject.transform.Find("MPlastic(Clone)").gameObject);
                setFalse();
            }
        }
        if (mPancake == true && IHaveItem == 1)
        {
            if (playernumber == 1)
            {
                FindObjectOfType<PlayerDirector>().GetItem("MPancake", 1);
                Destroy(gameObject.transform.Find("MPancake(Clone)").gameObject);
                setFalse();
            }
            if (playernumber == 2)
            {
                FindObjectOfType<PlayerDirector>().GetItem("MPancake", 2);
                Destroy(gameObject.transform.Find("MPancake(Clone)").gameObject);
                setFalse();
            }
        }

    }
    //Iron Plastic
    void CompleteIron()
    {
        IHaveItem = 1;
        iron = false;
        cIron = true;
    }
    void MissIron()
    {
        IHaveItem = 1;
        cIron = false;
        mIron = true;
    }
    void CompletePlastic()
    {
        IHaveItem = 1;
        plastic = false;
        cPlastic = true;
    }
    void MissPlastic()
    {
        IHaveItem = 1;
        cPlastic = false;
        mPlastic = true;
    }
    void CompletePancake()
    {
        IHaveItem = 1;
        pancake = false;
        cPancake = true;
    }
    void MissPancake()
    {
        IHaveItem = 1;
        cPancake = false;
        mPancake = true;
    }
    void CompleteCandy()
    {
        IHaveItem = 1;
        sugar = false;
        water = false;
        candy = true;
    }
    void CompleteCream()
    {
        IHaveItem = 1;
        egg = false; cream = false;
        cCream = true;
    }
    void CompleteChocolateCream()
    {
        IHaveItem = 1;
        cCream = false; cChocolate = false;
        chocolateCream = true;
    }
    void Redbaka()
    {
        var parent = this.transform;
        Instantiate(RedScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
        //子オブジェクトを削除
        Destroy(gameObject.transform.Find("RedWool(Clone)").gameObject);
        //Invoke("Redbaka1", 1.0f);
    }
   
    void Redbaka1()
    {
        Destroy(gameObject.transform.Find("RedScarf(Clone)").gameObject);
        GiftGen.DeliveryPresents += 1;
        obj.GetComponent<resipi>().Getitem(RedScarf);
        setFalse();
    }
    void Bluebaka()
    {
        var parent = this.transform;
        Instantiate(BlueScarf, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity, parent);
        //子オブジェクトを削除
        Destroy(gameObject.transform.Find("BlueWool(Clone)").gameObject);
        //Invoke("Bluebaka1", 1.0f);
    }

    void Bluebaka1()
    {
        Destroy(gameObject.transform.Find("BlueScarf(Clone)").gameObject);
        GiftGen.DeliveryPresents += 1;
        obj.GetComponent<resipi>().Getitem(BlueScarf);
        setFalse();
    }
    void setFalse()
    {
        IHaveItem = 0;
        CanItem = false; redWool = false; blueWool = false; paper = false; leather = false; iron = false; rubber = false; plastic = false; pancake = false; cream = false; chocolateCream = false; strawberry = false;
        conductingWire = false; package = false; candy = false; cookie = false; chocolate = false; redCloth = false; blackCloth = false; whiteCloth = false; soft = false; cSoft = false; gamePackage = false; cotton = false; cloth = false;
        ribbon = false; pinkGift = false; redGift = false; yellowGift = false; greenGift = false; blueGift = false; purpleGift = false; redScarf = false; blueScarf = false; book = false; car = false;
        airplane = false; cake = false; chocolateCake = false; gameConsole = false; software = false; assort = false; robot = false; radiocotrolled = false; dool = false; redClothes = false; blackClothes = false; whiteClothes = false;
        pinkRedScarf = false; pinkBlueScarf = false; pinkBook = false; pinkCar = false; pinkAirplane = false; pinkCake = false; pinkChocolateCake = false; pinkGameConsole = false; pinkSoftware = false; pinkAssort = false; pinkRobot = false; pinkRadiocotrolled = false; pinkDool = false; pinkRedClothes = false; pinkBlackClothes = false; pinkWhiteClothes = false;
        redRedScarf = false; redBlueScarf = false; redBook = false; redCar = false; redAirplane = false; redCake = false; redChocolateCake = false; redGameConsole = false; redSoftware = false; redAssort = false; redRobot = false; redRadiocotrolled = false; redDool = false; redRedClothes = false; redBlackClothes = false; redWhiteClothes = false;
        yellowRedScarf = false; yellowBlueScarf = false; yellowBook = false; yellowCar = false; yellowAirplane = false; yellowChocolateCake = false; yellowCake = false; yellowGameConsole = false; yellowSoftware = false; yellowAssort = false; yellowRobot = false; yellowRadiocotrolled = false; yellowDool = false; yellowRedClothes = false; yellowBlackClothes = false; yellowWhiteClothes = false;
        greenRedScarf = false; greenBlueScarf = false; greenBook = false; greenCar = false; greenAirplane = false; greenChocolateCake = false; greenCake = false; greenGameConsole = false; greenSoftware = false; greenAssort = false; greenRobot = false; greenRadiocotrolled = false; greenDool = false; greenRedClothes = false; greenBlackClothes = false; greenWhiteClothes = false;
        blueRedScarf = false; blueBlueScarf = false; blueBook = false; blueCar = false; blueAirplane = false; blueChocolateCake = false; blueCake = false; blueGameConsole = false; blueSoftware = false; blueAssort = false; blueRobot = false; blueRadiocotrolled = false; blueDool = false; blueRedClothes = false; blueBlackClothes = false; blueWhiteClothes = false;
        purpleRedScarf = false; purpleBlueScarf = false; purpleBook = false; purpleCar = false; purpleAirplane = false; purpleChocolateCake = false; purpleCake = false; purpleGameConsole = false; purpleSoftware = false; purpleAssort = false; purpleRobot = false; purpleRadiocotrolled = false; purpleDool = false; purpleRedClothes = false; purpleBlackClothes = false; purpleWhiteClothes = false;
        sugar = false; water = false; egg = false; cCream = false; cChocolate = false; cCIron = false; cRubber = false; cCPlastic = false; controller = false; cPaper = false; cLeather = false; cStrawberry = false; bag = false; cCandy = false; pinkController = false; redController = false; yellowController = false; greenController = false; blueController = false; purpleController = false; squeezing = false; cCCream = false; cChocolateCream = false; cPancake = false; mPancake = false; cIron = false; mIron = false; cPlastic = false; mPlastic = false;
    }




}
