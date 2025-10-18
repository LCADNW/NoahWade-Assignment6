using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour //no need for a different movement script
{
    public GameObject player; //plop GameObject in and that will be the player
    [SerializeField] float playerSpeed = 3f; //set the speed of player
    [SerializeField] float playerJumpPower = 2f; //give jump force
    public Rigidbody rb;

    private bool isGrounded = true; //grounded check, not initiated yet (greyed out)

   
    void Update()
    {
        //movement time - help from ChatGPT
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        //no need for moveZ, that will be jump
        Vector3 move = new Vector3(moveX, 0, moveY) * playerSpeed;
        Vector3 newPos = new Vector3(move.x, rb.velocity.y, move.z);
        rb.velocity = newPos;


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * playerJumpPower, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            // Simple ground check — player can jump again when hitting something
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }
    }
}
