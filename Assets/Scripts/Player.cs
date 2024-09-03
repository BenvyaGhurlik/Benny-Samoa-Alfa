using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public ControlType controlType;
    public Joystick joystick; 
    public float speed;

    public enum ControlType{PC, Android}

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(controlType == ControlType.PC )
        {
            joystick.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }

        if(controlType == ControlType.PC)
        {
             moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else if (controlType == ControlType.Android)
        {
            moveInput = new Vector2(joystick.Horizontal, joystick.Vertical); 
        }
        moveVelocity = moveInput.normalized * speed;

        if(!facingRight && moveInput.x > 0)
        {
            Flip();
        }
        else if (facingRight && moveInput.x < 0)
        {
            Flip();
        }
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime); 
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = rb.transform.localScale;
        Scaler.x *= 1;
        transform.localScale = Scaler;
    }
}