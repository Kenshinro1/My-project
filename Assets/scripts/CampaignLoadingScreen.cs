using UnityEngine;
using UnityEngine.SceneManagement;  // Required for scene loading

public class CampaignloadScreen : MonoBehaviour
{
    // This function will be called when the "Campaign" button is clicked
    public void LoadMainMenu()
    {
        // Replace "MainMenu" with the actual name of your main menu scene
        SceneManager.LoadScene("Loading Screen");  // Ensure the scene name matches the one you have
    }
}