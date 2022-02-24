using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        GameObject.Find("SceneChanger").GetComponent<SceneChanger>().FadeToScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        GameObject.Find("SceneChanger").GetComponent<SceneChanger>().FadeToScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }
}
