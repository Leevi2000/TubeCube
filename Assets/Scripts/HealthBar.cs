using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthBar : MonoBehaviour
{
    int currentHp;
    int previousHp;
    GameObject player;
    public Slider slider;
    // Start is called before the first frame update
    //void Start()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");
    //    currentHp = player.GetComponent<PlayerHp>().hp;
    //    previousHp = player.GetComponent<PlayerHp>().hp;
    //}

    //// Update is called once per frame
    //void FixedUpdate()
    //{
    //    currentHp = player.GetComponent<PlayerHp>().hp;
    //    if (currentHp != previousHp)
    //    {
    //        StartCoroutine(ShrinkHpBar());
    //    }
    //    previousHp = currentHp;
    //}

    IEnumerator ShrinkHpBar(int health)
    {
        while(true)
        {
            float toReduce = 100 - health;
            slider.value = slider.value - Mathf.Sqrt(toReduce);
            toReduce = toReduce - Mathf.Sqrt(toReduce);
            yield return new WaitForFixedUpdate();
            if (toReduce <= health)
            {
                break;
            }
        }
        
    }

    public void SetHealth(int health)
    {
        StartCoroutine(ShrinkHpBar(health));
    }
}
