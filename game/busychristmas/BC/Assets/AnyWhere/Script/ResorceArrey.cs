using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResorceArrey
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

    GameObject Sugar; GameObject Water; GameObject CCream; GameObject Egg; GameObject CChocolate; GameObject CIron; GameObject CPlastic; GameObject CRubber; GameObject CCIron; GameObject CCPlastic; GameObject Controller; GameObject CPaper; GameObject CLeather; GameObject CStrawberry; GameObject CPancake; GameObject Bag; GameObject CCandy; GameObject PinkController; GameObject RedController; GameObject YellowController; GameObject GreenController; GameObject BlueController; GameObject PurpleController; GameObject Squeezing; GameObject CCCream; GameObject CChocolateCream;





    GameObject[] allobject;

    public void Initialize()
    {
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









        GameObject[] newobject = {
            RedWool,
            BlueWool,
            Pancake,
            Cream,
            ChocolateCream,
            Strawberry,
            Paper,
            Leather,
            Iron,
            Rubber,
            Plastic,
            ConductingWire,
            Soft,
            CSoft,
            Package,
            Candy,
            Cookie,
            Chocolate,
            RedCloth,
            BlackCloth,
            WhiteCloth,
            Cotton,
            Cloth,
            RedScarf,
            BlueScarf,
            Book,
            Car,
            Airplane,
            Cake,
            ChocolateCake,
            GameConsole,
            Software,
            Assort,
            Robot,
            Radiocotrolled,
            Dool,
            RedClothes,
            BlackClothes,
            WhiteClothes,
            PinkGift,
            RedGift,
            YellowGift,
            GreenGift,
            BlueGift,
            PurpleGift,
            Ribbon,
            GamePackage,
            PinkRedScarf,
            RedRedScarf,
            YellowRedScarf,
            GreenRedScarf,
            BlueRedScarf,
            PurpleRedScarf,
            PinkBlueScarf,
            RedBlueScarf,
            YellowBlueScarf,
            GreenBlueScarf,
            BlueBlueScarf,
            PurpleBlueScarf,
            PinkBook,
            RedBook,
            YellowBook,
            GreenBook,
            BlueBook,
            PurpleBook,
            PinkCar,
            RedCar,
            YellowCar,
            GreenCar,
            BlueCar,
            PurpleCar,
            PinkAirplane,
            RedAirplane,
            YellowAirplane,
            GreenAirplane,
            BlueAirplane,
            PurpleAirplane,
            PinkCake,
            RedCake,
            YellowCake,
            GreenCake,
            BlueCake,
            PurpleCake,
            PinkChocolateCake,
            RedChocolateCake,
            YellowChocolateCake,
            GreenChocolateCake,
            BlueChocolateCake,
            PurpleChocolateCake,
            PinkGameConsole,
            RedGameConsole,
            YellowGameConsole,
            GreenGameConsole,
            BlueGameConsole,
            PurpleGameConsole,
            PinkSoftware,
            RedSoftware,
            YellowSoftware,
            GreenSoftware,
            BlueSoftware,
            PurpleSoftware,
            PinkAssort,
        RedAssort,
        YellowAssort,
        GreenAssort,
        BlueAssort,
        PurpleAssort,
        PinkRobot,
        RedRobot,
        YellowRobot,
        GreenRobot,
        BlueRobot,
        PurpleRobot,
        PinkRadiocotrolled,
        RedRadiocotrolled,
        YellowRadiocotrolled,
        GreenRadiocotrolled,
        BlueRadiocotrolled,
        PurpleRadiocotrolled,
        PinkDool,
        RedDool,
        YellowDool,
        GreenDool,
        BlueDool,
        PurpleDool,
        PinkRedClothes,
        RedRedClothes,
        YellowRedClothes,
        GreenRedClothes,
        BlueRedClothes,
        PurpleRedClothes,
        PinkBlackClothes,
        RedBlackClothes,
        YellowBlackClothes,
        GreenBlackClothes,
        BlueBlackClothes,
        PurpleBlackClothes,
        PinkWhiteClothes,
        RedWhiteClothes,
        YellowWhiteClothes,
        GreenWhiteClothes,
        BlueWhiteClothes,
        PurpleWhiteClothes,
        Sugar,
        Water,
        Egg,
        CCream,
        CChocolate,
        CIron,
        CPlastic,
        CRubber,
        CCIron,
        CCPlastic,
        Controller,
        CPaper,
        CLeather,
        CStrawberry,
        CPancake,
        Bag,
        PinkController,
        RedController,
        YellowController,
        GreenController,
        BlueController,
        PurpleController,
        Squeezing,
        CCCream,
        CChocolateCream
        };


        //newobject.CopyTo(allobject, 0);
    }

    public int ArrayLength()
    {
        return allobject.Length;
    }

    public GameObject Allobject(int number)
    {
        return allobject[number];
    }


    GameObject a;
    public GameObject Search(string name)
    {
        a = null;
        if (name.Contains("RedWool"))
        {
            a = RedWool;
        }
        if (name.Contains("BlueWool"))
        {
            a = BlueWool;
        }
        if (name.Contains("RedScarf"))
        {
            a = RedScarf;
        }
        if (name.Contains("BlueScarf"))
        {
            a = BlueScarf;
        }

        return a;
    }
}
