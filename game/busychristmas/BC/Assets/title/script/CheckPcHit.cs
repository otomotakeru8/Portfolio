using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPcHit : MonoBehaviour
{
    public AudioClip sfxSelect;
    public AudioClip sfxDecision;
    AudioSource asMain;

    void Start()
    {
        asMain = GetComponent<AudioSource>();
    }

    void OnTriggerStay(Collider collider)
    {
    	if(collider.gameObject.name == "Pc1Wrapper")
    	{
    		if(this.transform.name == "begin")
    		{
                // asMain.PlayOneShot(sfxSelect);
                TitleScreen.MenuSelection = 0;
		    }
    		else if(this.transform.name == "config")
    		{
                // asMain.PlayOneShot(sfxSelect);
                TitleScreen.MenuSelection = 1;
			}
			else if(this.transform.name == "exit")
			{
                // asMain.PlayOneShot(sfxSelect);
                TitleScreen.MenuSelection = 2;
			}
		}
    }
    
    void OnTriggerExit(Collider other)
    {
    	TitleScreen.MenuSelection = -1;
    }
}
