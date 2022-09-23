
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
    //[SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private GameObject projectile;
    public float fireVelocity = 1500f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
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