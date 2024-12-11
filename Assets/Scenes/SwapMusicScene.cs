using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapMusicScenes : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (SceneManager.GetActiveScene().name == "DemoScene")
            BackMusic.instance.GetComponent<AudioSource>().Pause();
        //BGmusic.instance.GetComponent<AudioSource>().Play();

    }
}