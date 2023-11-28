using UnityEngine;
using TMPro;

public class DropdownManager : MonoBehaviour 
{
    private TMP_Dropdown dropdown;

    // cache a reference to the parent GameObjects Dropdown component
    private void Awake()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }

    // retreive and print out the current value of the dropdown
    public void PrintNewValue()
    {
        // retreive the integer dropdown menu position selected
        int currentValue = dropdown.value;

        // output details of new value to Console
        print ("option changed to = " + currentValue);
	}
}
