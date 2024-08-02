using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            NPCHealth npcHealth = other.GetComponent<NPCHealth>();
            if (npcHealth != null)
            {
                npcHealth.TakeDamage(100); // Top NPC'yi tek at��ta yok eder
            }
            gameObject.SetActive(false); // Topu devre d��� b�rak
        }
    }
}
