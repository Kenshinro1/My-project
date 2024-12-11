using UnityEngine;
using DentedPixel;

public class Bar : MonoBehaviour
{
    public GameObject Barss; // The GameObject to animate 
    public float time;     // Duration of the animation

    // Called before the first frame update
    void Start()
    {
        AnimateBarss();
    }

    // Method to animate the bar scaling along the X-axis
    public void AnimateBarss()
    {
        if (Barss != null)
        {
            // Scales the Bar's X-axis to 1 over 'time' seconds
            LeanTween.scaleX(Barss, 1f, time);
        }
        else
        {
            Debug.LogError("Barss GameObject is not assigned!");
        }
    }
}