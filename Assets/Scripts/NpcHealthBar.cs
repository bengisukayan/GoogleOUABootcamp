using UnityEngine;
using UnityEngine.UI;

public class NpcHealthBar : MonoBehaviour
{
    public Image healthBarImage; // Can bar�n�n Image bile�eni

    public void SetMaxHealth(float health)
    {
        healthBarImage.fillAmount = 1f; // Sa�l�k bar�n� tamamen doldur
    }

    public void SetHealth(float health)
    {
        // Sa�l�k bar�n�n doluluk oran�n� g�ncelle
        healthBarImage.fillAmount = Mathf.Clamp01(health / 100f);
    }
}
