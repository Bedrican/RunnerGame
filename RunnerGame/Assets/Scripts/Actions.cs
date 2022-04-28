using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public static class Actions
{
    public static Action<float> OnHeightChanged;
    public static Action OnGameOver;
    public static Action OnPowerUp;
    public static Action OnGameFinish;
    public static Action<float> OnScoreNeed;
    public static Action<int> SetScoreText;
    public static Action<int> SetCoinsText;
}
