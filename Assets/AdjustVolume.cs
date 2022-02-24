using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustVolume : MonoBehaviour
{
    public AudioSource music;
    float targetVolume = 0.4f;
   
    void Start()
    {
        music.volume = 0.1f;
        StartCoroutine(SetVolume());
    }

    IEnumerator SetVolume()
    {
        while(true)
        {
            yield return new WaitForFixedUpdate();

            if (music.volume < targetVolume)
            {
                music.volume = music.volume + 0.001f;
            }
            else { break; }
        }
    }
}
