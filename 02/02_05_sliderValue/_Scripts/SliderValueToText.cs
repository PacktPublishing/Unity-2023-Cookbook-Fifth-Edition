using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI;
    private TextMeshProUGUI textSliderValue;

    void Awake()
    {
        textSliderValue = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Slider value = " + sliderUI.value;
        textSliderValue.text = sliderMessage;
    }
}

