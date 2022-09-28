using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerMove : MonoBehaviour
{
    [SerializeField] private ActivePlayerManger manager;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;
    [SerializeField] public float jumpForce = 2;
    public bool isOnGround = true;
    private Rigidbody playerRidgidbody;


    private void Start()
    {

    }
    // Update is called once per frame  whateverIcallmyplayer.transform.forward
    void Update()
    {
        ActivePlayer currentPlayer = manager.GetCurrentPlayer();

        if (Input.GetAxis("Horizontal") != 0)
        {
            currentPlayer.transform.Rotate(currentPlayer.transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            currentPlayer.transform.Translate(currentPlayer.transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            currentPlayer.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
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
