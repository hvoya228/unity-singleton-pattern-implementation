using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreText : MonoBehaviour
{
    private Text scoreText;
    private ScoreController scoreController;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreController = ScoreController.Instance;
        ScoreToText();
    }

    private void ScoreToText()
    {
        scoreText.text = "score: " + scoreController.ScoreCount.ToString();
    }
}
