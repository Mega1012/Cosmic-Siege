using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemController : MonoBehaviour
{
    public static InputSystemController instanceInputSystem;
    public static Vector2 Move { get; set; } = Vector2.zero;
    private void Awake()
    {
        instanceInputSystem = this;
    }

    public void MoveManager(InputAction.CallbackContext value) => Move = value.ReadValue<Vector2>();
}