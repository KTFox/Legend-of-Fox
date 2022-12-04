using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate1 : MonoBehaviour
{
    //Variables
    float timeLoadNextScene = 2f;



    //Methods
    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(loadNextScene());
    }
    IEnumerator loadNextScene()
    {
        yield return new WaitForSecondsRealtime(timeLoadNextScene);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
