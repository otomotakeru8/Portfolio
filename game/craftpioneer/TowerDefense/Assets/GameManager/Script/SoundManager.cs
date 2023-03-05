using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    SettingsData settingsData;

    [SerializeField]
    AudioClip[] bgm;
    [SerializeField]
    AudioClip[] se;

    [SerializeField]
    AudioSource bgmAudioSource;
    [SerializeField]
    AudioSource seAudioSource;

    private float m_bgmvolume;
    private float m_sevolume;

    Dictionary<string, int> bgmIndex = new Dictionary<string, int>();
    Dictionary<string, int> seIndex = new Dictionary<string, int>();

    private void Start()
    {
        if (!(bgm.Length == 0))
        {
            for (int i = 0; i < bgm.Length; i++)
            {
                if (EqualityComparer<AudioClip>.Default.Equals(bgm[i], default(AudioClip)) == false)
                {
                    bgmIndex.Add(bgm[i].name, i);
                }
            }
        }
        if (!(se.Length == 0))
        {
            for (int i = 0; i < se.Length; i++)
            {
                if (EqualityComparer<AudioClip>.Default.Equals(bgm[i], default(AudioClip)) == false)
                {
                    seIndex.Add(se[i].name, i);
                }
            }
        }
        if (bgmAudioSource != null)
        {
            bgmAudioSource.volume = settingsData.bgmVolume;
        }
        if (seAudioSource != null)
        {
            seAudioSource.volume = settingsData.seVolume;
        }
    }

    public int GetBgmIndex(string name)
    {
        int index = 0;
        foreach (KeyValuePair<string, int> item in bgmIndex)
        {
            byte[] data = Encoding.UTF8.GetBytes(item.Key);
            byte[] valuedata = Encoding.UTF8.GetBytes(name);
            StringBuilder datasb = new StringBuilder(20000);
            StringBuilder valuedatasb = new StringBuilder(20000);
            for (int i = 0; i < data.Length; i++)
            {
                datasb.Append(data[i]);
            }
            for (int i = 0; i < valuedata.Length; i++)
            {
                valuedatasb.Append(valuedata[i]);
            }

            if (datasb.Equals(valuedatasb))
            {
                index = item.Value;
            }
            else
            {
                Debug.LogError("指定された名前のBGMファイルが存在しません。");
                index = -1;
            }
        }
        return index;
    }
    public int GetSEIndex(string name)
    {
        int index = 0;
        foreach (KeyValuePair<string, int> item in seIndex)
        {
            byte[] data = Encoding.UTF8.GetBytes(item.Key);
            byte[] valuedata = Encoding.UTF8.GetBytes(name);
            StringBuilder datasb = new StringBuilder(20000);
            StringBuilder valuedatasb = new StringBuilder(20000);
            for (int i = 0; i < data.Length; i++)
            {
                datasb.Append(data[i]);
            }
            for (int i = 0; i < valuedata.Length; i++)
            {
                valuedatasb.Append(valuedata[i]);
            }

            if (datasb.Equals(valuedatasb))
            {
                index = item.Value;
            }
            else
            {
                Debug.LogError("指定された名前のSEファイルが存在しません。");
                index = -1;
            }
        }
        return index;
    }

    //BGM再生
    public void PlayBgm(int index)
    {
        index = Mathf.Clamp(index, 0, bgm.Length);
        bgmAudioSource.clip = bgm[index];
        bgmAudioSource.loop = true;
        bgmAudioSource.volume = settingsData.bgmVolume;
        bgmAudioSource.Play();
    }
    public void PlayBgmByName(string name)
    {
        PlayBgm(GetBgmIndex(name));
    }
    //BGM停止
    public void StopBgm()
    {
        bgmAudioSource.Stop();
        bgmAudioSource.clip = null;
    }

    //SE再生
    public void PlaySe(int index)
    {
        index = Mathf.Clamp(index, 0, se.Length);
        seAudioSource.PlayOneShot(se[index], settingsData.seVolume);
    }
    public void PlaySeByName(string name)
    {
        PlaySe(GetSEIndex(name));
    }
    //SE停止
    public void StopSe()
    {
        seAudioSource.Stop();
        seAudioSource.clip = null;
    }
}
