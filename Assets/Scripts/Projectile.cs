using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage = 10f;  // Topun verece�i hasar miktar�

    private void OnCollisionEnter(Collision collision)
    {
        // Karakterin tag'ini kontrol edin
        if (collision.gameObject.CompareTag("Player"))
        {
            CanBari canBari = collision.gameObject.GetComponent<CanBari>();
            if (canBari != null)
            {
                canBari.TakeDamage(damage);  // Can� azaltma metodunu �a��r�n
                Debug.Log("Top karaktere �arpt�, hasar verildi.");
            }

            // Topu deaktivasyon
            gameObject.SetActive(false);
        }
    }
}
