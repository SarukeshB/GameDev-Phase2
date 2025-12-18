using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    void Start()
    {
        // ... (empty in the image)
    }

    void Update()
    {
        // ... (empty in the image)
    }

    public void Intro1Game()
    {
        SceneManager.LoadScene(1);
    }
        public void Intro2Game()
    {
        SceneManager.LoadScene(2);
    }
        public void Intro3Game()
    {
        SceneManager.LoadScene(3);
    }
        public void StartGame()
    {
        SceneManager.LoadScene(4);
    }
        public void PauseGame()
    {
        SceneManager.LoadScene(5);
    }
            public void MainGame()
    {
        SceneManager.LoadScene(0);
    }
        public void QuitGame()
    {
        Application.Quit();
    }
}