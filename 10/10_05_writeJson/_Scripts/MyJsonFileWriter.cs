using UnityEngine;
using System.IO; 

public class MyJsonFileWriter : MonoBehaviour
{
    public string folderName = "Data";
    public string fileName = "player.json";
    private PlayerScore player1Score;
    
    private void Awake()
    {
        player1Score = new PlayerScore();
        player1Score.name = "matt";
        player1Score.score = 800;
    }

    void Start()
    {
        // get JSON data from PlayerScore object
        string stringData = player1Score.ToJson();

        // setup folder name and path to file to be created
        string folderAndFileName = Path.Combine(folderName, fileName);
        string filePath = Path.Combine(Application.dataPath, folderAndFileName);
        
        // write JSON string data to file
        WriteTextFile(filePath, stringData);
    }
    
    public void WriteTextFile(string pathAndName, string stringData)
    {
        // create new empty file
        FileInfo textFile = new FileInfo(pathAndName);
        StreamWriter writer = textFile.CreateText();

        // write text to file
        writer.Write(stringData);

        // close file
        writer.Close();
    }

}