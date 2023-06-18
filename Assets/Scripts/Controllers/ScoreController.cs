using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private int scoreCount;

    public int ScoreCount { get { return scoreCount; } }
    public static ScoreController Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log(gameObject.name + " deleted");
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
