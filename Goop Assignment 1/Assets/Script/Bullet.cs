using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    //[SerializeField] private ActivePlayerManger manager;
    //[SerializeField] private Button botton;
    private bool collided;

    void Start()
    {
        //botton.onClick.AddListener(ButtonPressed);
    }
    public void ButtonPressed()
    {
        //ActivePlayer currentPlayer = manager.GetCurrentPlayer();
        //currentPlayer.FireProjectile();
    }
    void Awake()
    {

    }
    void OnCollisionEnter(Collision collider) 
    {
        if (collider.gameObject.tag != "Bullet" && collider.gameObject.tag != "Player" && !collided)
        {
            collided = true;
            Destroy(gameObject);
        }
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log(collider.gameObject);
            collider.gameObject.GetComponent<PlayerHealthB>().TakeDamage(10);
        }

    }
}
