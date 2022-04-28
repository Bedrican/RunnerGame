using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightChangeManager : MonoBehaviour
{
    
    private void OnEnable()
    {
       Actions.OnHeightChanged += HeightChange;
       Actions.OnGameFinish += FinishScore;

    }

    private void OnDisable()
    {
        Actions.OnHeightChanged -= HeightChange;
        Actions.OnGameFinish -= FinishScore;
    }

    public void HeightChange(float height)
    {
        transform.localScale += new Vector3(0,height,0);
        if (transform.localScale.y <= 0)
        {
            transform.localScale = new Vector3(transform.localScale.x , 0, transform.localScale.z);
            Actions.OnGameOver();
        }
    }

    public void FinishScore()
    {
        Actions.OnScoreNeed(transform.localScale.y * 4 * 10);
    }
}
