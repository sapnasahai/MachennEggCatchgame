using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Game changes apply");
    }

    
    public void Quit()
    {
        Debug.Log("Close Application");
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene("Level Setup");
    }



    public void storyNext()
    {
        SceneManager.LoadScene("Instructions");
    }



    public void instrctionNext()
    {
        SceneManager.LoadScene("Register");
    }




}
