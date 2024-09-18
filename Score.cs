using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI mainText;

    void Awake()
    {
        mainText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        UpdateScoreText(); // Initially set the text
    }

    // Public function to update the score and text
    public void AddScore()
    {
        score ++;
        Debug.Log("SCORE ADDED" + score);
        UpdateScoreText();
    }

    // Private method to update the text
    private void UpdateScoreText()
    {
        mainText.text = score.ToString();
    }
}
