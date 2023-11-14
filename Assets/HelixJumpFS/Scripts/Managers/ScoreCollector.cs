using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;


    [SerializeField] private int scores;
    public int Scores => scores;


    [SerializeField] private int maxScores;
    public int MaxScores => maxScores;


    protected override void Awake()
    {
        base.Awake();
        LoadMaxScores();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel;
        }

        if (type == SegmentType.Finish)
        {
            if (scores > maxScores)
            {
                maxScores = scores;
                SaveMaxScores();
            }
        }

    }

    private void SaveMaxScores()
    {
        PlayerPrefs.SetInt("ScoreCollector:MaxScores", maxScores);
    }

    private void LoadMaxScores()
    {
        maxScores = PlayerPrefs.GetInt("ScoreCollector:MaxScores", 0);
    }
}
