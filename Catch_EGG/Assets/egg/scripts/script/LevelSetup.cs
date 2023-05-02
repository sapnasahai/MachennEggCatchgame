using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSetup : MonoBehaviour
{
    public GameObject levelSetUI;


    public void Easylevel()
    {
        
        SceneManager.LoadScene("Basket_Selection");
    }


    public void Mediumlevel()
    {

        SceneManager.LoadScene("Game  4");
    }

    public void Hardlevel()
    {

        SceneManager.LoadScene("Game  4");
    }


}
