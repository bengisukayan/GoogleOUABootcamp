using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text healthText; // Text bile�enini ekleyin

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
        UpdateHealthText(health); // Can miktar�n� g�ncelleyin
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        UpdateHealthText(health); // Can miktar�n� g�ncelleyin
    }

    private void UpdateHealthText(int health)
    {
        if (healthText != null)
        {
            healthText.text = health.ToString(); // Can miktar�n� metin olarak g�sterin
        }
    }
}
