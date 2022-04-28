using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPosition : MonoBehaviour
{
    private void OnEnable()
    {
        Actions.OnHeightChanged += RepositionCharacter;
    }

    private void OnDisable()
    {
        Actions.OnHeightChanged += RepositionCharacter;
    }

    public void RepositionCharacter(float amount)
    {
        transform.localPosition += new Vector3(0, amount*4 , 0);
    }
}
