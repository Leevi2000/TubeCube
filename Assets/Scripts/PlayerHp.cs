using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHp : MonoBehaviour
{
    public int maxHp = 100;

    [SerializeField]
    public int hp = 0;

    public GameObject hitParticle;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        healthBar.SetHealth(maxHp);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        }
    }
}
