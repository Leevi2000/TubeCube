using UnityEngine;

public class DifficultyScaling : MonoBehaviour
{
    float timeElapsed = 0;
    public float firingSpeedMultiplier = 1;
    public float score = 0;
    public ScoreText scoreTextScript;
    public GameObject endCanvas;
    // Start is called before the first frame update
    void Start()
    {
        endCanvas.active = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeElapsed = timeElapsed + Time.deltaTime;
        if (firingSpeedMultiplier < 3.5f)
        {
            firingSpeedMultiplier = 1 + (timeElapsed / 25);
        }

        score = score + Time.deltaTime * 20;

        scoreTextScript.SetScore(score);
    }
}
