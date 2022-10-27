using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public bool isShooting;

    public void OnFire(InputAction.CallbackContext ctx)
    {
        if (ctx.started) isShooting = true;
        if (ctx.canceled) isShooting = false;
    }
}
