using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Cambiamento async delle scene
public class ChangeSceneAsync : MonoBehaviour
{

    AsyncOperation sceneAO;
    public GameObject loadingUI;
    public Slider loadingProgbar;
    public Text loadingText;

    private const float LOAD_READY_PERCENTAGE = 0.90f;

    public void ChangeScene(string sceneName)
    {
        loadingUI.SetActive(true);
        loadingText.text = "0%";
        StartCoroutine(LoadingSceneRealProgress(sceneName));
    }

    IEnumerator LoadingSceneRealProgress(string sceneName)
    {
        yield return new WaitForSeconds(1);
        sceneAO = SceneManager.LoadSceneAsync(sceneName);

        // disable scene activation while loading to prevent auto load
        sceneAO.allowSceneActivation = false;

        while (!sceneAO.isDone)
        {
            loadingProgbar.value = sceneAO.progress;
            loadingText.text = ((int)(loadingProgbar.value * 100)+11).ToString()+"%";

            if (sceneAO.progress >= LOAD_READY_PERCENTAGE)
            {
                loadingProgbar.value = 1f;
                sceneAO.allowSceneActivation = true;
                
            }
            Debug.Log(sceneAO.progress);
            yield return null;
        }
    }
}

