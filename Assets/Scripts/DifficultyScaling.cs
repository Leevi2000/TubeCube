fusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyScaling : MonoBehaviour
{
    float timeElapsed = 0;
    public float firingSpeedMultiplier = 1;
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeElapsed = timeElapsed + Time.deltaTime;
        if (firingSpeedMultiplier < 3.5f)
        {
            firingSpeedMultiplier = 1 + (timeElapsed / 50);
        }

        score = score + Time.deltaTime * 20;
    }
}
