using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private ActivePlayerManger manager;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float rotationSpeed;
    [SerializeField] public float jumpForce = 5;
    //[SerializeField] private PlayerTurn playerTurn;
    public bool isOnGround = true;
    private float horizontalInput;
    private float forwardInnput;
    private Rigidbody playerRidgidbody;

    private void Start()
    {
        playerRidgidbody = GetComponent<Rigidbody>();

        if (Input.GetAxis("Horizontal") != 0)
        {
            ActivePlayer currentPlayer = manager.GetCurrentPlayer();
        }
    }

    private void Update()
    {
        // Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInnput = Input.GetAxis("Vertical");

        // Move the player forward
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInnput);

        //Let Player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRidgidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            ActivePlayer currentPlayer = manager.GetCurrentPlayer();
            this.transform.Rotate(Vector3.up, -0.5f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ActivePlayer currentPlayer = manager.GetCurrentPlayer();
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