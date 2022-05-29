using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneRestart()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    public void sceneStart()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    public void sceneQuit()
    {
        Application.Quit();
    }
    public void sceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
