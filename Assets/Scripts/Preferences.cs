using UnityEngine;

public class Preferences : MonoBehaviour
{
    public static int gridSize; 
    public TMPro.TMP_Dropdown gridSizeDropdown;

    public void SetGridSize()
    {
        gridSize = gridSizeDropdown.value + 1; // Assuming dropdown options are 1-indexed
    }
}
