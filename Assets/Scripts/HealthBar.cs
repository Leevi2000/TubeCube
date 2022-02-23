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
    
    void Start()
    {
        slider.value = 100;
    }

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

    public void SetHealth(int health)
    {
        StartCoroutine(ShrinkHpBar(health));
    }
    IEnumerator ShrinkHpBar(int health)
    {

        while (true)
        {

            yield return new WaitForSecondsRealtime(0.01f);

            if (slider.value == health)
            {
                break;
            }
            else
            {
                slider.value = slider.value - 1;
            }
            
            
        }
        
    }

 
}
