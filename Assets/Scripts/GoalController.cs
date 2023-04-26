using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isHome;

    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ball){
            if(isHome){
                manager.AddHomeScore(1);
            }else{
                manager.AddAwayScore(1);
            }
        }
    }
}
