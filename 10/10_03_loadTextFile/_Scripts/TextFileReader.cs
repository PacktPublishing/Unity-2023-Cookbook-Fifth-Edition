using System;
using UnityEngine;
using TMPro;
public class TextFileReader : MonoBehaviour
{
	// text file containing city data
	public TextAsset textFile;

	// reference to UI text box component
	private TextMeshProUGUI _textComponent;

	private void Awake()
	{
		_textComponent = GetComponent<TextMeshProUGUI>();
	}

	void Start()
	{
		// // (1) declare a newline character variable
		// char newlineChar = '\n';
	 //
		// // (3) read in and make array from level data		
  //   	string citiesText = levelDataTextFile.text.Split(newlineChar);

		string citiesText = textFile.text;
		
		// (4) call the method to build this maze
		_textComponent.text = citiesText;
	}

}

