using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStates : MonoBehaviour
{
    public static MainGameStates instance;
    private void OnEnable()
    {
        instance = this;
    }

    public bool isMovementAvailable = true;

}
