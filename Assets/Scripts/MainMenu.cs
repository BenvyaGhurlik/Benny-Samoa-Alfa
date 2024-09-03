using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Debug.Log("Занято нахуй");
        Application.Quit();
    }
    public void Click()
    {
        Application.OpenURL("https://discord.gg/4w9pdwBmmZ"); 
    }
}
