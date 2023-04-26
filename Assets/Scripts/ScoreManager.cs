using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int homeScore;
    public int awayScore;

    public int maxScore;

    public BallController ball;

    public void AddHomeScore(int increment){
        homeScore += increment;
        ball.ResetBall();
        if(homeScore >= maxScore){
            GameOver();
        }
    }

    public void AddAwayScore(int increment){
        awayScore += increment;
        ball.ResetBall();
        if(awayScore >= maxScore){
            GameOver();
        }
    }

    public void GameOver(){
        SceneManager.LoadScene("Game");
    }
}
