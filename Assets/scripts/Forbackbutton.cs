using UnityEngine;
using UnityEngine.SceneManagement;  // Required for scene loading

public class LoadCampaignLoadingScreen : MonoBehaviour
{
    // This function will be called when the "Back" button is clicked
    public void LoadScreen()
    {
        // Replace "MainMenu" with the actual name of your main menu scene
        SceneManager.LoadScene("CampaignLoad");  // Ensure the scene name matches the one you have
    }
}
