using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadingSelection : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(2); 
    }
}