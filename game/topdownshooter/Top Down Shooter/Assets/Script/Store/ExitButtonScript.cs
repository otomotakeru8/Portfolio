using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Exit);
    }

    void Exit()
    {
        FindObjectOfType<Store>().StorOff();
        FindObjectOfType<WaveScript>().Nextwave();
    }
}
