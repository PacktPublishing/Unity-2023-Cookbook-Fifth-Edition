using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class WebTextFileReader : MonoBehaviour
{
    // text file containing city data
    public string url = "https://filesamples.com/samples/code/json/sample1.json";

    // reference to UI text box component
    private TextMeshProUGUI _textComponent;

    private void Awake()
    {
        _textComponent = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        StartCoroutine( LoadWWW() );
    }

    private IEnumerator LoadWWW()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            webRequest.certificateHandler = new CertHandler();

            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(": Error: " + webRequest.error);
                    _textComponent.text = "ERROR: " + webRequest.error;
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(": HTTP Error: " + webRequest.error);
                    _textComponent.text = "ERROR: " + webRequest.error;
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);
                    _textComponent.text = webRequest.downloadHandler.text;
                    break;
            }
        }

    }
}

