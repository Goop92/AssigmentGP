using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthB : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public static bool isGameOver;

    public HealthB healthB;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthB.SetMaxHealth(maxHealth);
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {        
        currentHealth -= damage;
        healthB.SetHealth(currentHealth);
        Debug.Log("Take damage körs");

        if (currentHealth <= 0)
        {

            isGameOver = true;
            Destroy(gameObject);
        }
    }
}
