using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
