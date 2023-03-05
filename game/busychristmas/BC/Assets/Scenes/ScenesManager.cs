using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesManager : MonoBehaviour
{
    public void TitleScene()
    {
        SceneManager.LoadScene("title");
        Time.timeScale = 1;
    }
    public void WorldselectionScene()
    {
        SceneManager.LoadScene("Worldselection");
        Time.timeScale = 1;
    }
    public void JapanStage1()
    {
        SceneManager.LoadScene("Japanst1");
    }
    public void JapanStage2()
    {
        SceneManager.LoadScene("Japanst2");
    }
    public void JapanStage3()
    {
        SceneManager.LoadScene("Japanst3");
    }
    public void JapanStage4()
    {
        SceneManager.LoadScene("Japanst4");
    }
    public void JapanStage5()
    {
        SceneManager.LoadScene("Japanst5");
    }
    public void AmericaStage1()
    {
        SceneManager.LoadScene("st2-1");
    }
    public void AmericaStage2()
    {
        SceneManager.LoadScene("st2-2");
    }
    public void AmericaStage3()
    {
        SceneManager.LoadScene("st2-3");
    }
    public void AmericaStage4()
    {
        SceneManager.LoadScene("st2-4");
    }
    public void AmericaStage5()
    {
        SceneManager.LoadScene("st2-5");
    }
    public void AustraliaStage1()
    {
        SceneManager.LoadScene("ThePinnacles");
    }
    public void AustraliaStage2()
    {
        SceneManager.LoadScene("Mine");
    }
    public void AustraliaStage3()
    {
        SceneManager.LoadScene("Uluru");
    }
    public void AustraliaStage4()
    {
        SceneManager.LoadScene("ThreeSisters");
    }
    public void AustraliaStage5()
    {
        SceneManager.LoadScene("GreatBarrierReef");
    }
    public void ResultScene()
    {
        SceneManager.LoadScene("Result");
    }
    public void FirstMapScene()
    {
        SceneManager.LoadScene("FirstMap");
    }
    public void BackScene()
    {
        if (Common.SScene == "Japanst1")
        {
            SceneManager.LoadScene("Japanst1");
        }
        if (Common.SScene == "Japanst2")
        {
            SceneManager.LoadScene("Japanst2");
        }
        if (Common.SScene == "Japanst3")
        {
            SceneManager.LoadScene("Japanst3");
        }
        if (Common.SScene == "Japanst4")
        {
            SceneManager.LoadScene("Japanst4");
        }
        if (Common.SScene == "Japanst5")
        {
            SceneManager.LoadScene("Japanst5");
        }
        if (Common.SScene == "st1")
        {
            SceneManager.LoadScene("st1");
        }
        if (Common.SScene == "st2")
        {
            SceneManager.LoadScene("st2");
        }
        if (Common.SScene == "st3")
        {
            SceneManager.LoadScene("st3");
        }
        if (Common.SScene == "st4")
        {
            SceneManager.LoadScene("st4");
        }
        if (Common.SScene == "st5")
        {
            SceneManager.LoadScene("st5");
        }
        if (Common.SScene == "ThePinnacles")
        {
            SceneManager.LoadScene("ThePinnacles");
        }
        if (Common.SScene == "Mine")
        {
            SceneManager.LoadScene("Mine");
        }
        if (Common.SScene == "Uluru")
        {
            SceneManager.LoadScene("Uluru");
        }
        if (Common.SScene == "ThreeSisters")
        {
            SceneManager.LoadScene("ThreeSisters");
        }
        if (Common.SScene == "GreatBarrierReef")
        {
            SceneManager.LoadScene("GreatBarrierReef");
        }
    }
}
