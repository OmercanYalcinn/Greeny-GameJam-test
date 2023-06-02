using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public Animator animator;
    private int inventoryCapNow = 0;
    
    [SerializeField] public float moveSpeed = 3f;

    //private Vector2 mousePosition;
    //private Vector2 lookingDirection;
    private Vector2 movement;
    

    void Update()
    {
        TakingInput();
    }
    void FixedUpdate()
    {
        //phys
        OnMovement();   
    }

    void TakingInput()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        // mouse position to aim actually
        //mousePosition = cam.ScreenToViewportPoint(Input.mousePosition);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        transform.position = transform.position + movement * Time.deltaTime;
    }

    void OnMovement()
    {
        //rigidbody2d.MovePosition = new(rigidbody2d.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        /*
        lookingDirection = mousePosition - rigidbody2d.position;
        float aimAngle = Mathf.Atan2(lookingDirection.y, lookingDirection.x) * Mathf.Rad2Deg - 90f;
        rigidbody2d.rotation = aimAngle;
        */
    }

}
