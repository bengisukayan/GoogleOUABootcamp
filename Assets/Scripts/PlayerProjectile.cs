using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public int damage = 100; // Topun verdi�i hasar miktar�

    void OnTriggerEnter(Collider other)
    {
        // NPC'ye �arpt���nda hasar ver
        if (other.CompareTag("NPC"))
        {
            NPCHealth npcHealth = other.GetComponent<NPCHealth>();
            if (npcHealth != null)
            {
                npcHealth.TakeDamage(damage);
            }

            // Top NPC'ye �arpt���nda topu devre d��� b�rak
            gameObject.SetActive(false);
        }
    }
}
