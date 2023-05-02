using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public GameObject game_manager, start_menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Button()
    {
        start_menu.SetActive(false);
        game_manager.SetActive(true);
        Debug.Log("button workk");
    }


}
