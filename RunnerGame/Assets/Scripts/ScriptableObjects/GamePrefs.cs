using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/GamePrefs")]
public class GamePrefs : ScriptableObject
{
   public GameObject money;
   public int incomeLevel =1;
   public int stackLevel =1;
   public int levelUpCostAmount = 100;
   public int maxStackLevel = 10;
   public int stackUpgradeCost = 10;
   public int incomeUpgradeCost = 10;
   public int maxCost = 1000;
   public int level=1;
   public int levelIndex=0;
}
