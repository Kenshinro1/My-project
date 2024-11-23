using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    [SerializeField]
    private Image progressbar;

    // Start is called before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start async operation
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        // Create an async operation
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(1);
        gameLevel.allowSceneActivation = false; // Prevent immediate scene activation

        while (!gameLevel.isDone)
        {
            // Map progress (0.0 to 0.9) to progress bar fill (0.0 to 1.0)
            float progress = Mathf.Clamp01(gameLevel.progress / 0.9f);
            progressbar.fillAmount = progress;

            // Check if loading is complete
            if (gameLevel.progress >= 0.9f)
            {
                // Activate the scene after the loading bar is full
                gameLevel.allowSceneActivation = true;
            }

            yield return new WaitForEndOfFrame(); // Fixed typo
        }
    }
}
