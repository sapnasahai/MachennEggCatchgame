using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;



public class BasketManager : MonoBehaviour 
{
    public GameObject[] baskets;
    public int selectedBasket = 0;

    public void NextOption()
    {
        baskets[selectedBasket].SetActive(false);
        selectedBasket = (selectedBasket + 1) % baskets.Length;
        baskets[selectedBasket].SetActive(true);
    }

    public void BackOption()
    {
        baskets[selectedBasket].SetActive(false);
        selectedBasket--;
        if (selectedBasket < 0)
        {
            selectedBasket += baskets.Length;
        }
        baskets[selectedBasket].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedBasket", selectedBasket);
        SceneManager.LoadScene("Game changes apply");
        Debug.Log("Selection saved: " + selectedBasket);
    }
}




