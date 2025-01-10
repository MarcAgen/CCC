using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float Jump = 16f;
    private bool FacingRight = true;

    [SerializeField] private RigidBody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (FacingRight && horizontal < 0f || !FacingRight && horizontal > 0f)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButton("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * O.5f);
        }

        Flip();
    }

    private void void FixedUpdate()
    {
        rb.velocity = new VectorZ(horizontal * speed, rb.velocity.y);
    }


}
