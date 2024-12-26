using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainKeyboardControl : MonoBehaviour
{
    private MainGameStates GState;
    private KeyboardKeys KCKeyboard;

    public static MainKeyboardControl instance;
    private void OnEnable()
    {
        instance = this;
    }

    private void Awake()
    {
        GState = MainGameStates.instance;
        KCKeyboard = KeyboardKeys.instance;
    }

    private void Update()
    {
        if (GState.isMovementAvailable)
        {
            CursorMoments();
        }
    }

    public void CursorMoments()
    {
        if (Input.GetKeyDown(KCKeyboard.KC_select))
        {
            Debug.Log("Selecting");
        }

    }

}