using UnityEngine;

public class NPCHealth : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            TakeDamage(100); // Tek vuru�ta �lmesi i�in b�y�k bir hasar ver
            collision.gameObject.SetActive(false); // Topu yeniden kullanmak i�in devre d��� b�rak
        }
    }
}
