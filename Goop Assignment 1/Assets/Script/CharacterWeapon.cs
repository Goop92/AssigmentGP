
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
    [SerializeField] private ActivePlayerManger manager;
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject playerShoot;
    public float fireVelocity = 1500f;

    private void Update()
    {
        ActivePlayer currentPlayer = manager.GetCurrentPlayer();
        if (Input.GetButtonDown("Fire1") && currentPlayer == playerShoot.GetComponent<ActivePlayer>())
        {
            GameObject FireObject = Instantiate(projectile, transform.position, transform.rotation);
            FireObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, fireVelocity));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject FireObject = Instantiate(projectile, transform.position, transform.rotation);
            FireObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, fireVelocity));
        }


    }
}