using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Hit")
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
        if(other.gameObject.tag == "Finish")
        {
            LoadNextLevel();
        }
    }
    void LoadNextLevel()
    {
        int currentSceneIndex =SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}

