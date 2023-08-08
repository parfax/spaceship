using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public bool isShooting;

    private Controls playerControls;

    private void Awake()
    {
        playerControls = GetComponent<Controls>();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
        playerControls.PlayerInput.Fire.started -= OnFire;
        playerControls.PlayerInput.Pause.started -= Pause;
    }

    private void Start()
    {
        playerControls.PlayerInput.Pause.performed += Pause;
        playerControls.PlayerInput.Fire.started += OnFire;
        playerControls.PlayerInput.Fire.canceled += OnFire;
    }

    public void Pause(InputAction.CallbackContext ctx)
    {
        //if (ctx.started) isShooting = true;
        //if (ctx.canceled) isShooting = false;
    }
    
    public void OnFire(InputAction.CallbackContext ctx)
    {
        if (ctx.started) isShooting = true;
        if (ctx.canceled) isShooting = false;
    }
}
