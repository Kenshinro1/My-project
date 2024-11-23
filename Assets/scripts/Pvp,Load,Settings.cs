using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OpenPvP()
    {
        SceneManager.LoadScene("PVP"); // Replace with your scene name
    }

    public void OpenLoadGame()
    {
        SceneManager.LoadScene("Loadgame"); // Replace with your scene name
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings"); // Replace with your scene name
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuSelection"); // Replace with your main menu scene name
    }
        
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