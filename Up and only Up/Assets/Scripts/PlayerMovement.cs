using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;
    public float movement;

    [Header("Components")]

    [SerializeField] private Rigidbody2D _rigitbody;

    [SerializeField] private bool _lookRight;

    private void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * _moveSpeed * Time.deltaTime;

        CheckFlip();
    }

    public void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigitbody.velocity.y ) < 0.05f)
        {
            _rigitbody.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
        }
    }

    private void CheckFlip()
    {
        if(movement < 0 && !_lookRight)
        {
            Flip();
        }
        else if(movement > 0 && _lookRight)
        {
            Flip();
        }
    }
    
    private void Flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        _lookRight = !_lookRight;
    }
}