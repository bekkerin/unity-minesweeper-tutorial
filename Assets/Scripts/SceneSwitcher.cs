using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{

    private void OnEnable()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);

    }

    public void ToPreferences()
    {
        SceneManager.LoadScene("Preferences");
    }

    public void ToMinesweeper()
    {
        SceneManager.LoadScene("Minesweeper");
    }

    public void ToExit()
    {
        SceneManager.LoadScene("Exit");
    }

    public void ToIntro()
    {
        SceneManager.LoadScene("Intro");
    }


}
