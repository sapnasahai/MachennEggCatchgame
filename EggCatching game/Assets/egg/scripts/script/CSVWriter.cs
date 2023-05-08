using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class CSVWriter : MonoBehaviour
{
    string filename = "";

    [System.Serializable]

    public class Player
    {
        public string name;
        //public TMP_InputField usernameInput;
        //public int highscore;
        public TMP_Text player_highscoreText;

    }


    [System.Serializable]

    public class Playerlist
    {
        public Player[] player;
    }

    public Playerlist myPlayerList = new Playerlist();


    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/test.csv";
    }

    // Update is called once per frame
    void Update()
    {

        WriteCSV();
    }

    public void WriteCSV()
    {

        if(myPlayerList.player.Length > 0)
        {
            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine(" Name , Highscore");
            tw.Close();


            tw = new StreamWriter(filename, true);

            for(int i = 0; i < myPlayerList.player.Length; i++)
            {
                tw.WriteLine(myPlayerList.player[i].name + "," + myPlayerList.player[i].player_highscoreText);
            }

            tw.Close();
        }
    }








}
