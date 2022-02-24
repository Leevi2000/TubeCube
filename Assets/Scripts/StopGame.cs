using UnityEngine;
using System.Collections;


public class StopGame : MonoBehaviour
{
    public GameObject endCanvas;
    public void StopTime()
    {
        StartCoroutine(FreezeSlowDown());
        EndGame();
    }

    IEnumerator FreezeSlowDown()
    {
        while(true)
        {
            if (Time.timeScale > 0)
            {
                Time.timeScale = Time.timeScale - 0.01f;
            }
            else
            {
                Time.timeScale = 0;
                break;
            }
            yield return new WaitForSeconds(0.001f);
        }
     
    }

    public void EndGame()
    {
        endCanvas.active = true;
    }
}
