using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanBari : MonoBehaviour
{
    public float can = 100f; // Ba�lang�� can de�eri
    public float maxCan = 100f; // Maksimum can de�eri
    public float animasyonYavasligi = 10f; // Animasyonun h�z�n� belirler
    public GameObject gameOverUI; // Game Over UI elementi

    private void Start()
    {
        // Ba�lang��ta can de�eri maksimum olmal�
        can = maxCan;

        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false); // Ba�lang��ta Game Over UI'yi gizle
        }
    }

    private void Update()
    {
        // NaN veya Infinity kontrol� ekleyin
        if (float.IsNaN(can) || float.IsInfinity(can))
        {
            can = maxCan; // Ge�erli bir de�er atay�n
        }

        // Can de�erinin s�f�r veya negatif olmas�n� �nle
        if (can < 0) can = 0;
        if (can > maxCan) can = maxCan;

        // Can bar� i�in ger�ek �l�e�i hesapla
        float gercekscale = can / maxCan;

        // Mevcut �l�e�i hedef �l�e�e do�ru de�i�tir
        Vector3 currentScale = transform.localScale;
        Vector3 targetScale = new Vector3(gercekscale, currentScale.y, currentScale.z);

        // NaN veya Infinity kontrol� ekleyin
        if (float.IsNaN(targetScale.x) || float.IsInfinity(targetScale.x))
        {
            targetScale.x = 0f; // Ge�erli bir de�er atay�n
        }

        // �l�ek de�i�imi yap
        transform.localScale = Vector3.Lerp(currentScale, targetScale, Time.deltaTime * animasyonYavasligi);

        // Oyun bitti�inde UI'yi g�ster ve oyunu durdur
        if (can <= 0)
        {
            if (gameOverUI != null)
            {
                gameOverUI.SetActive(true); // Game Over ekran�n� g�ster
            }
            Time.timeScale = 0; // Oyun durdurulacak
            Debug.Log("Oyun Bitti!"); // Konsola oyun bitti mesaj� yazd�r
        }
    }

    public void TakeDamage(float amount)
    {
        can -= amount;
        Debug.Log("Can azald�: " + can);
        if (can < 0)
        {
            can = 0;
        }
    }
}
