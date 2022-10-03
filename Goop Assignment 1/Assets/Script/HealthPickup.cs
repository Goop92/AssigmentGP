using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    PlayerHealthB playerHealthB;

    public HealthB healthB;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AddHealth(other);
        }
    }

    void AddHealth(Collider player)
    {
        PlayerHealthB stats = player.GetComponent<PlayerHealthB>();
        stats.currentHealth += 20;

       

        Destroy(gameObject);
    }
}
