using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightChangeManager : MonoBehaviour
{
    
    private void OnEnable()
    {
       Actions.OnHeightChanged += HeightChange;
    }

    private void OnDisable()
    {
        Actions.OnHeightChanged -= HeightChange;
    }

    public void HeightChange(float height)
    {
        transform.localScale += new Vector3(0,height,0);
        if (transform.localScale.y <= 0)
        {
            Actions.OnGameOver();
        }
    }
}
