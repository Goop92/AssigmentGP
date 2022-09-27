using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerCamera : MonoBehaviour
{
    [SerializeField] private ActivePlayerManger manager;
    [SerializeField] private Vector3 distansceFromThePlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = manager.GetCurrentPlayer().transform.position + distansceFromThePlayer;
    }
}
