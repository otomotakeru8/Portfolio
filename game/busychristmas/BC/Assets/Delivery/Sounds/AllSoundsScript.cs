using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSoundsScript : MonoBehaviour
{
    [SerializeField] AudioClip[] sound = new AudioClip[1];
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PopSE(int num)
    {
        audioSource.PlayOneShot(sound[num]);
    }

    public void LoopBGM()
    {
        audioSource.Play();
        audioSource.loop = true;
    }

    public void StopSound()
    {
        audioSource.Stop();
    }

}
