using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainKeyboardControl : MonoBehaviour
{
    private MainGameStates GState;
    private KeyboardKeys KCKeyboard;

    public GameObject cursorObject;
    public float cursorSpeed;
    [SerializeField] private int movingX = 0;
    [SerializeField] private int movingY = 0;

    private bool setupComplete = false;

    public static MainKeyboardControl instance;

    private void OnEnable()
    {
        instance = this;
    }

    private void Start()
    {
        GState = MainGameStates.instance;
        KCKeyboard = KeyboardKeys.instance;
        setupComplete = true;
    }

    private void Update()
    {
        if (setupComplete)
        {
            if (GState.isMovementAvailable)
            {
                CursorMoments();
            }
        }
    }

    public void CursorMoments()
    {
        if (Input.GetKeyDown(KCKeyboard.KC_select))
        {
            Debug.Log("Selecting");
        }

        #region
        if (Input.GetKeyDown(KCKeyboard.KC_movementLeft))
        {
            movingX--;
        }
        else if (Input.GetKeyUp(KCKeyboard.KC_movementLeft))
        {
            movingX++;
        }
        if (Input.GetKeyDown(KCKeyboard.KC_movementRight))
        {
            movingX++;
        }
        else if (Input.GetKeyUp(KCKeyboard.KC_movementRight))
        {
            movingX--;
        }
        if (Input.GetKeyDown(KCKeyboard.KC_movementUp))
        {
            movingY++;
        }
        else if (Input.GetKeyUp(KCKeyboard.KC_movementUp))
        {
            movingY--;
        }
        if (Input.GetKeyDown(KCKeyboard.KC_movementDown))
        {
            movingY--;
        }
        else if (Input.GetKeyUp(KCKeyboard.KC_movementDown))
        {
            movingY++;
        }
        #endregion


        if (movingX != 0)
        {
            cursorObject.transform.position += new Vector3(movingX * cursorSpeed,0) * Time.deltaTime;
        }

        if (movingY != 0)
        {
            cursorObject.transform.position += new Vector3(0, movingY * cursorSpeed) * Time.deltaTime;
        }
    }

}