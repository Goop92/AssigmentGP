using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerInput : MonoBehaviour
{
    [SerializeField] private ActivePlayerManger manager;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;

    // Update is called once per frame  whateverIcallmyplayer.transform.forward
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            ActivePlayer currentPlayer = manager.GetCurrentPlayer();
            currentPlayer.transform.Rotate(currentPlayer.transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            ActivePlayer currentPlayer = manager.GetCurrentPlayer();
            currentPlayer.transform.Translate(currentPlayer.transform.forward * rotationSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
        }
    }
}
