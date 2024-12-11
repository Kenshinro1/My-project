using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayCampaign : MonoBehaviour
{
    public string loadingSceneName = "LoadingScreen"; // Name of the loading screen scene

    // Starts the campaign by loading the next scene with the loading screen
    public void StartCampaign()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            StartCoroutine(LoadSceneWithLoadingScreen(nextSceneIndex));
        }
        else
        {
            Debug.LogWarning("No more scenes in build settings!");
        }
    }

    // Coroutine to load the scene with a loading screen
    private IEnumerator LoadSceneWithLoadingScreen(int sceneToLoadIndex)
    {
        // Load the loading screen additively
        AsyncOperation loadingScreenOperation = SceneManager.LoadSceneAsync(loadingSceneName, LoadSceneMode.Additive);
        yield return new WaitUntil(() => loadingScreenOperation.isDone);

        // Start loading the target scene asynchronously
        AsyncOperation targetSceneOperation = SceneManager.LoadSceneAsync(sceneToLoadIndex);
        targetSceneOperation.allowSceneActivation = false; // Prevent the scene from activating immediately

        // Simulate a loading delay and update logic here (optional)
        while (targetSceneOperation.progress < 0.50f)
        {
            // You can add a progress bar update here using `targetSceneOperation.progress`
            yield return null;
        }

        // Simulate some additional delay (optional)
        yield return new WaitForSeconds(2f); // Adjust time as necessary for your loading screen duration

        // Activate the scene once fully loaded
        targetSceneOperation.allowSceneActivation = true;

        // Wait for the scene activation
        yield return new WaitUntil(() => targetSceneOperation.isDone);

        // Unload the loading screen
        SceneManager.UnloadSceneAsync(loadingSceneName);
    }

    // Quit the game
    public void QuitGame()
    {
        Debug.Log("Quit Game triggered.");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}