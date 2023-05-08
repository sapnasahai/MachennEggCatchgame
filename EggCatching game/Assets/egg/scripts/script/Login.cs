using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Login : MonoBehaviour
{

    public TMP_InputField usernameInput;

    public TMP_InputField passwordInput;


    public Button loginButton;
    public Button goToregisterButton;


    ArrayList credentials;


    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(login);
        goToregisterButton.onClick.AddListener(moveToRegister);


        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            Debug.Log("Credential file doesn't exist");
        }





    }



    private void login()
    {

        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));

        foreach (var i in credentials)
        {
            string line = i.ToString();

            if (i.ToString().Substring(1, i.ToString().IndexOf(" : ")).Equals(usernameInput.text) &&
                i.ToString().Substring(1,i.ToString().IndexOf(" : ") + 1).Equals(passwordInput.text))

            {
                isExists = true;
                break;
            }


            if (isExists)
            {
                Debug.Log($"Logging in '{usernameInput.text}'");
                loadGameDemo();
            }


            else
            {
                Debug.Log("Incurrect credentials");
            }
        }



    }




   void moveToRegister()
   {
        SceneManager.LoadScene("Register");
   }


    void loadGameDemo()
    {
        SceneManager.LoadScene("Game Demo");
    }
    

}
