using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unitmovement : MonoBehaviour
{
    private Vector3 targetPosition;

    private void Update()  
    {
        Vector3 moveDirection = (targetPosition - transform.position).normalized;
        transform.position += moveDirection * Time.deltaTime;
        float movceSpeed = 4f;
        transform.position += moveDirection * movceSpeed * Time.deltaTime;

        //testing press key down
        if (Input.GetKeyDown(KeyCode.T))
        {
            Move(new Vector3(4, 0, 4));
        }
    }
    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}
