using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlaySound : MonoBehaviour
{
    public float speed = 0;
    Vector3 previousPos;

    AudioSource audioSource;
    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        previousPos = transform.position;
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = ((transform.position - previousPos).magnitude) / Time.deltaTime;
        previousPos = transform.position;

    }

    private void OnCollisionEnter(Collision collider)
    {
        
        if (speed > 3 && this.gameObject != null)
        {
            audioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Length - 1)]);
        }
        else
        {
            
        }
    }
}
