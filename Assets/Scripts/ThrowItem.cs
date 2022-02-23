using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItem : MonoBehaviour
{
    public GameObject[] items;
    public float coolDown;
    public float timeScale = 1;

    AudioSource audioSource;
    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        timeScale = GameObject.FindGameObjectWithTag("GameManager").GetComponent<DifficultyScaling>().firingSpeedMultiplier;
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeScale = GameObject.FindGameObjectWithTag("GameManager").GetComponent<DifficultyScaling>().firingSpeedMultiplier;
        coolDown = coolDown - Time.deltaTime;
        if (coolDown < 0)
        {
            PlaySound();
            Quaternion newRot = Quaternion.Euler(Random.Range(-20, 20), Random.Range(150, 210), Random.Range(-20, 20));
            transform.rotation = newRot;
            GameObject itemToSpawn = items[Random.Range(0, items.Length-1)];
            Instantiate(itemToSpawn, transform.position, transform.rotation);
            coolDown = Random.Range(3f, 5f) - timeScale;
            if (coolDown < 0.1f) { coolDown = 0.1f; }
        }
    }

    void PlaySound()
    {
        audioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Length - 1)]);
    }
}
