using UnityEngine;

public class PickupUI : MonoBehaviour 
{
    public GameObject iconColor;
    public GameObject iconGray;

    void Awake()
    {
        DisplayEmpty();
    }

    public void DisplayColorIcon()
    {
        iconColor.SetActive(true);
        iconGray.SetActive(false);
    }

    public void DisplayGreyIcon()
    {
        iconColor.SetActive(false);
        iconGray.SetActive(true);
    }

    public void DisplayEmpty()
    {
        iconColor.SetActive(false);
        iconGray.SetActive(false);
    }
}