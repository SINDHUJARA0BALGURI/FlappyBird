using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transTime = 1.0f;
    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("End");

        yield return new WaitForSeconds(transTime);
        SceneManager.LoadScene(levelIndex);
    }
}
