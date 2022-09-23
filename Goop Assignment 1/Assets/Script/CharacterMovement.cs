using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] public float jumpForce = 5;
    //[SerializeField] private PlayerTurn playerTurn;
    public bool isOnGround = true;
    private float horizontalInput;
    private float forwardInnput;
    private Rigidbody playerRidgidbody;

    private void Start()
    {
        playerRidgidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInnput = Input.GetAxis("Vertical");

        // Move the player forward
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInnput);

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }
        //Let Player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRidgidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -0.5f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, 0.5f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

}