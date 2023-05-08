using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_setting : MonoBehaviour
{

    public string Gender;

    public string Name;

    public string Age;

    public string Blood_G;

    public string Physicial_Name;

    public string Level;

    public float Time_limit;

    public int Num_of_eggs;



    public TMP_InputField Name_input, age_input, Bloodg_input, Physcian_input;

    public Text Warning_text;

    public GameObject LoginPanel, Level_set_Panel, Cart_set_Panle,Game_panle,Parent_panel;

    public List<Sprite> Baskets = new List<Sprite>();

    public Image Baseket_Image;

    public List<GameObject> Tick_image = new List<GameObject>();
    public void Set_Gender(string gen)
    {
        Gender = gen;
    }

    public void Set_Profile()
    {
        if (string.IsNullOrEmpty(Name_input.text) || string.IsNullOrEmpty(age_input.text) || string.IsNullOrEmpty(Bloodg_input.text) || string.IsNullOrEmpty(Physcian_input.text)|| string.IsNullOrEmpty(Gender))
        {
            Warning_text.text = "Please fill all the field";
        }
        else
        {
            Name = Name_input.text;
            Age = age_input.text;
            Blood_G = Bloodg_input.text;
            Physicial_Name = Physcian_input.text;
            LoginPanel.SetActive(false);
            Level_set_Panel.SetActive(true);

        }
    }

    public void Set_level(int n)
    {
        switch (n)
        {
            case 0:
                Level = "Easy";
                Time_limit = 30f;
                Num_of_eggs = 10;
            break;
            case 1:
                Level = "Medium";
                Time_limit = 60f;
                Num_of_eggs = 20;
                break;
            case 2:
                Level = "Hard";
                Time_limit = 90f;
                Num_of_eggs = 30;
                break;
        }

        Level_set_Panel.SetActive(false);
        Cart_set_Panle.SetActive(true);
    }

    public void Select_basket(int i)
    {
        Baseket_Image.sprite = Baskets[i];

        foreach (var item in Tick_image)
        {
            item.SetActive(false);
        }

        Tick_image[i].SetActive(true);
    }

    public void Play_Game()
    {
        Cart_set_Panle.SetActive(false);
        Game_panle.SetActive(true);
        Parent_panel.SetActive(false);
    }

    public void Back_to_Login()
    {
        Name = "";
        Age = "";
        Blood_G ="";
        Physicial_Name = "";
        Gender = "";
        LoginPanel.SetActive(true);
        Level_set_Panel.SetActive(false);

        Name_input.text = "";
        age_input.text = "";
        Bloodg_input.text = "";
        Physcian_input.text = "";
    }

    public void Back_to_level_set()
    {
        Level = "";
        Time_limit = 0;
        Num_of_eggs = 0;

        Cart_set_Panle.SetActive(false);
        Level_set_Panel.SetActive(true);

        foreach (var item in Tick_image)
        {
            item.SetActive(false);
        }


    }

    public void Home()
    {
        Back_to_Login();
        Back_to_level_set();

    }

}
