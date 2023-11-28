using UnityEngine;
using TMPro;

public class GameTime : MonoBehaviour
{
    private TextMeshProUGUI uiText;
    private float startTime;
    
    void Awake()
    {
        uiText = GetComponent<TextMeshProUGUI>();
        startTime = Time.time;
    }

    void Update()
    {
        float elapsedSeconds = (Time.time - startTime);
        
        // 1 decimal place
        string timeMessage = "Elapsed time = " + elapsedSeconds.ToString ("F");
        uiText.text = timeMessage;
    }
}
