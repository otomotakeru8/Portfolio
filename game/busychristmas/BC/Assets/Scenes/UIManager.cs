using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject CountryPanel;
    [SerializeField] private GameObject JapanPanel;
    [SerializeField] private GameObject AmericaPanel;
    [SerializeField] private GameObject AustraliaPanel;

    // Start is called before the first frame update
    void Start()
    {
        CountryPanel.SetActive(true);
        JapanPanel.SetActive(false);
        AmericaPanel.SetActive(false);
        AustraliaPanel.SetActive(false);
    }
    public void JapanSelection()
    {
        CountryPanel.SetActive(false);
        JapanPanel.SetActive(true);
    }
    public void AmericaSelection()
    {
        CountryPanel.SetActive(false);
        AmericaPanel.SetActive(true);
    }
    public void AustraliaSelection()
    {
        CountryPanel.SetActive(false);
        AustraliaPanel.SetActive(true);
    }
    public void BackSelection()
    {
        CountryPanel.SetActive(true);
        JapanPanel.SetActive(false);
        AmericaPanel.SetActive(false);
        AustraliaPanel.SetActive(false);
    }
}
