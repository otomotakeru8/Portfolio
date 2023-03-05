using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirectorScript : MonoBehaviour
{
    public AudioClip shot1;
    public AudioClip shot2;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Application.targetFrameRate = 60;
    }

    public void sound1start()
    {
        audioSource.PlayOneShot(shot1);
    }

    public void sound2start()
    {
        audioSource.PlayOneShot(shot2);
    }

}
