
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    public void FadeToScene()
    {
        animator.SetTrigger("FadeOut");
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        animator = gameObject.GetComponent<Animator>();
    }
}
