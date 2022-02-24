using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHp : MonoBehaviour
{
    public int maxHp = 100;

    [SerializeField]
    public int hp = 0;

    AudioSource audioSource;
    public AudioClip[] audioClips;

    public GameObject hitParticle;
    public HealthBar healthBar;
    public StopGame stopScript;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        healthBar.SetHealth(maxHp);
        audioSource = this.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            hp = hp - 3 * Convert.ToInt32(collision.gameObject.GetComponent<ItemPlaySound>().speed);
            collision.gameObject.tag = "Untagged";
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
            Instantiate(hitParticle, collision.gameObject.transform.position, collision.gameObject.transform.rotation);

            healthBar.SetHealth(hp);

            if (hp <= 0) { stopScript.StopTime(); stopScript.EndGame(); }
            

            audioSource.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length - 1)]);
        }
    }
}
