using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class LeaderBoardManager : MonoBehaviour
{


    [SerializeField] TextAsset file;



    private void Start()
    {
        //Debug.Log(file.text);
        Readfile();
    }



    void Readfile()
    {
        var splitFile = new string[] { "\r\n" };
        var splitLine = new char[] { ':' };

        
        var Lines = file.text.Split(splitFile, System.StringSplitOptions.RemoveEmptyEntries);


        

        for (int i = 0; i< Lines.Length; i++)
        {
            Debug.Log("Line =" + Lines[i]);
            var line = Lines[i].Split(splitLine, System.StringSplitOptions.None);

            // string name = line[0];
            
        }



    }

    /*
    // Load the text file
    //TextAsset file = Resources.Load<TextAsset>("credentials");
    string fileContents = usernameInput.text;

    // Split the file contents by newline
    string[] lines = fileContents.Split('\n');

    // Loop through each line and extract the name
    string name = "";


    foreach (string line in lines)

    string[] parts = line.Split(':');
    
    if private static object usernameInput;

    (parts.Length >= 5)
    {
        name = parts[0];
        break;
    }*/

    
}
 










