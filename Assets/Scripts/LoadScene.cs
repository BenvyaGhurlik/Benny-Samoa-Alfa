using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LoadScene : MonoBehaviour
{
    public int sceneID; //загружаемая сцена

    public Slider loadSlider; //слайдер

    private void Start()
    {
        StartCoroutine(LoadNextScene()); 
    }

    IEnumerator LoadNextScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(sceneID);
        while (!oper.isDone)
        {
            float progress = oper.progress / 0.9f;
            loadSlider.value = progress;
            yield return null;
        }
    }

}
