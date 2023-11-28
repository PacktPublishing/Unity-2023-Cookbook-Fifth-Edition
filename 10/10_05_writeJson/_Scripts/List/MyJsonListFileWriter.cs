using UnityEngine;
using System.IO;

public class MyJsonListFileWriter : MonoBehaviour
{
    public string folderName = "Data";
    public string fileName = "playerList.json";
    private PlayerScore playerScore1 = new PlayerScore();
    private PlayerScore playerScore2 = new PlayerScore();
    private PlayerScoreList playerScoreList = new PlayerScoreList();

    void Awake()
    {
        playerScore1.name = "matt";
        playerScore1.score = 800;
        playerScore2.name = "joelle";
        playerScore2.score = 901;
        playerScoreList.list.Add(playerScore1);
        playerScoreList.list.Add(playerScore2);
    }

    void Start(){
        // setup folder name and path to file to be created
        string folderAndFileName = Path.Combine(folderName, fileName);
        string filePath = Path.Combine(Application.dataPath, folderAndFileName);

        // get JSON data from PlayerScore object
        string stringData = playerScoreList.ToJson();

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