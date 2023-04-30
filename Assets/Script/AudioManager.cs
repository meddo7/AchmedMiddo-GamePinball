using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudio;
    public GameObject sfxAudio;
    public GameObject sfxSwitchOnAudio;
    public GameObject sfxSwitchoffAudio;


    void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudio.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudio,spawnPosition, Quaternion.identity);
    }

    public void PlaySFXon(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchOnAudio, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXoff(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchoffAudio, spawnPosition, Quaternion.identity);
    }


}
