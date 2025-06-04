using UnityEngine;
using UnityEngine.UI;

public class AccessibilityManager : MonoBehaviour
{
    [Header("UI Elements")]
    public Toggle subtitlesToggle;
    public Toggle colorblindToggle;
    public Dropdown difficultyDropdown; // or TMP_Dropdown if using TextMeshPro

    [Header("Settings")]
    public bool subtitlesEnabled = false;
    public bool colorblindModeEnabled = false;
    public int difficultyLevel = 0;

    public void ApplySettings()
    {
        subtitlesEnabled = subtitlesToggle.isOn;
        colorblindModeEnabled = colorblindToggle.isOn;
        difficultyLevel = difficultyDropdown.value;

        // Temporary debug check
        Debug.Log("Settings Applied:\n" +
                  "Subtitles: " + subtitlesEnabled + "\n" +
                  "Colorblind: " + colorblindModeEnabled + "\n" +
                  "Difficulty: " + difficultyLevel);

        // TODO: Pass settings to other managers or save PlayerPrefs
    }
}
