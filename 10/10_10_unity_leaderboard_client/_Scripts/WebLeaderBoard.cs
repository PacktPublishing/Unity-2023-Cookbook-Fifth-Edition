// file: WebLeaderBoard.cs
// based on Unity example at:
// https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Networking.UnityWebRequest.Get.html

using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Networking;

using UnityEngine.UI;


public class WebLeaderBoard : MonoBehaviour
{
	public Text ui_lastURL;
	public Text ui_lastURLValue;
	public Text ui_textFile;

	public string leaderBoardURL = "http://localhost/leaderboard/index.php";
	private string uri = "(empty)";
	private string action;
	private string parameters;
	private string textFileContents = "(still loading file ...)";

	void Start(){
		UpdateUI();
	}

	private void UpdateUI() {
		ui_lastURL.text = "LAST URL = " + uri;
		ui_lastURLValue.text = StringToInt(textFileContents);
		ui_textFile.text = MakePretty(textFileContents);
	}

	private string MakePretty(string s)
	{
		string prettyText = s;

		// hide closing tag
//		string prettyText = s.Replace("</", "?@?"); 
		
		// prefix opening tag with newline
		prettyText = prettyText.Replace("<", "\n<"); 
		
		// prefix <li with newline
//		prettyText = prettyText.Replace("<li", "\n<li"); 
		
		// return closing tag 
		prettyText = prettyText.Replace("?@?", "</"); 

		// JSON newlinees
		prettyText = prettyText.Replace("{", "\n{");
		prettyText = prettyText.Replace("[", "\n[");
		prettyText = prettyText.Replace("]", "\n]");


		// replace blank lines
		prettyText = prettyText.Replace("\n\n", "\n"); 


		return prettyText;

	}

	private string StringToInt(string s) {
		string intMessage = "integer received = ";
		try{
			int integerReturned = Int32.Parse(s);
			intMessage += integerReturned;
		}
		catch(System.Exception){
			intMessage += "(not an integer) ";
			print (intMessage);
		}	
		return intMessage;
	}
	private IEnumerator LoadWWW(){
		uri = leaderBoardURL + "?action=" + action + parameters;
		
		using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
		{
			webRequest.certificateHandler = new CertHandler();

			// Request and wait for the desired page.
			yield return webRequest.SendWebRequest();

			string[] pages = uri.Split('/');
			int page = pages.Length - 1;

			switch (webRequest.result)
			{
				case UnityWebRequest.Result.ConnectionError:
				case UnityWebRequest.Result.DataProcessingError:
					Debug.LogError(pages[page] + ": Error: " + webRequest.error);
					ui_lastURLValue.text = "ERROR: " + webRequest.error;
					break;
				case UnityWebRequest.Result.ProtocolError:
					Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
					ui_lastURLValue.text = "ERROR: " + webRequest.error;
					break;
				case UnityWebRequest.Result.Success:
					Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
					textFileContents = webRequest.downloadHandler.text;
					UpdateUI();
					break;
			}
		}
		}

	


	
	//
	// public button Methods
 	//
	public void GetHTMLAction() {
		action = "get";
		parameters = "&username=matt&format=html";
		StartCoroutine( LoadWWW() );
	}

	public void GetTXTAction() {
		action = "get";
		parameters = "&username=matt&format=txt";
		StartCoroutine( LoadWWW() );
	}

	public void SetAction() {
		int randomScore = UnityEngine.Random.Range(500, 510);
		parameters = "&username=matt&score=" + randomScore;
		action = "update";
		StartCoroutine( LoadWWW() );
	}

	public void HTMLAction() {
		action = "list";
		parameters = "&format=html";
		StartCoroutine( LoadWWW() );
	}

	public void TXTAction() {
		action = "list";
		parameters = "&format=txt";
		StartCoroutine( LoadWWW() );
	}

	public void XMLAction() {
		action = "list";
		parameters = "&format=xml";
		StartCoroutine( LoadWWW() );
	}

	public void JSONAction() {
		action = "list";
		parameters = "&format=json";
		StartCoroutine( LoadWWW() );
	}

	public void ResetAction() {
		action = "reset";
		parameters = "";
		StartCoroutine( LoadWWW() );
	}
}
