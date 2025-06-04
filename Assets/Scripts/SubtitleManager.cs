using UnityEngine;

public class SubtitleManager : MonoBehaviour
{
    public GameObject subtitlesUI;

    void Start()
    {
        if (AccessibilityManager.subtitlesEnabled)
            subtitlesUI.SetActive(true);
        else
            subtitlesUI.SetActive(false);
    }
}
