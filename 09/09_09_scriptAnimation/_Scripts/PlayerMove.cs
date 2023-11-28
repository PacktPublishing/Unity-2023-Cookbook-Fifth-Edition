using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float vertical = 0;
    private float horizontal = 0;
    private Animator animator;
    public float rotateSpeed = 1;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {       
        // get forward / backward movement from Up/Down/W/S
        vertical = Input.GetAxis("Vertical");

        // get turn movement from Left/Right/A/D
        horizontal = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        animator.SetFloat("Speed", vertical);
        
        // Turn
        transform.Rotate(0, horizontal * rotateSpeed, 0);
    }
}