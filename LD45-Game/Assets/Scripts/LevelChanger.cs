using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    private string levelToLoad;

    public void FadeToLevel(string levelName)
    {
        levelToLoad = levelName;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeCompele()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
