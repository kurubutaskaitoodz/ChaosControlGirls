using UnityEngine;

public class KeyboardKeys : MonoBehaviour
{
    #region
    public static KeyboardKeys instance;
    private void OnEnable()
    {
        instance = this;
    }
    #endregion

    public KeyCode KC_movementUp = KeyCode.W;
    public KeyCode KC_movementDown = KeyCode.S;
    public KeyCode KC_movementLeft = KeyCode.A;
    public KeyCode KC_movementRight = KeyCode.D;

    public KeyCode KC_select = KeyCode.Space;
}