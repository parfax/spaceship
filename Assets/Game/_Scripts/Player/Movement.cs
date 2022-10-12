using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed;
    private Vector3 axis;

    [SerializeField]
    private InputActionReference movement;


    void Update()
    {
        axis.x = movement.action.ReadValue<float>();

        transform.position += axis * speed * Time.deltaTime;
    }
}
