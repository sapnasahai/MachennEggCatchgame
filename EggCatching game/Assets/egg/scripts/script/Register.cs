using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Register : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField ageInput;

    public TMP_InputField sexInput;
    public TMP_InputField bloodgroupInput;


    public TMP_InputField physiciannameInput;

    public TMP_InputField passwordInput;


    public Button registerButton;
    //public Button loginButton;


    ArrayList credentials;


    // Start is called before the first frame update
    void Start()
    {
        registerButton.onClick.AddListener(writeStuffToFileLogin);
        //loginButton.onClick.AddListener(loginScene);

        if(File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/credentials.txt", "");

        }





    }

   /* private void loginScene()
    {
        SceneManager.LoadScene("Login");
    }*/

    private void writeStuffToFileLogin()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        foreach(var i in credentials)
        {
            if (i.ToString().Contains(usernameInput.text))
            {
                isExists = true;
                break;
            }

            

            


        }

        if (isExists)
        {
            Debug.Log($"Username '{usernameInput.text}'already exists");
        }
        else
        {
            credentials.Add(usernameInput.text  + ":" + passwordInput.text  +":" + ageInput.text 
                +  ":"  + sexInput.text +  ":"  + bloodgroupInput.text +  ":"  + physiciannameInput.text );
            File.WriteAllLines(Application.dataPath + "/credentials.txt", (string[])credentials.ToArray(typeof(string)));
            Debug.Log("Account Registered");

            SceneManager.LoadScene("Game Settings");
        }






    }

    
}
