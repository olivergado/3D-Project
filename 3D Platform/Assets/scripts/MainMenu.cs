using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
