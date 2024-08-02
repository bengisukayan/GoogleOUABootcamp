using UnityEngine;

public class NpcProjectile : MonoBehaviour
{
    public float damage = 10f; // Topun verece�i hasar miktar� float t�r�nde olabilir

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                // Hasar miktar�n� int t�r�ne d�n��t�rerek g�nder
                playerHealth.TakeDamage(Mathf.RoundToInt(damage));
            }

            // Topu devre d��� b�rak
            gameObject.SetActive(false);
        }
        else
        {
            // E�er ba�ka bir �eye �arparsa da topu devre d��� b�rak
            gameObject.SetActive(false);
        }
    }
}
