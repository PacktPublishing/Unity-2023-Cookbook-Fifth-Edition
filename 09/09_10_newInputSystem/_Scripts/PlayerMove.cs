using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour, Controls.IPlayerActions
{
    private Vector2 _direction;
    private float vertical = 0;
    private float horizontal = 0;
    private Animator animator;
    public float rotateSpeed = 1;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<Vector2>();
        vertical = _direction.y;
        horizontal = _direction.x;
    }
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    
    void FixedUpdate()
    {
        animator.SetFloat("Speed", vertical);
        transform.Rotate(0, horizontal * rotateSpeed, 0);
        transform.Rotate(0, horizontal * rotateSpeed, 0);
    }
}
