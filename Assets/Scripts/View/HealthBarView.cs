using TMPro;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Slider healthSlider;

    public void Initialize(float currentHealth, float maxHealth)
    {
        healthSlider.maxValue = maxHealth;
        UpdateHealth(currentHealth);
    }

    public void UpdateHealth(float health)
    {
        healthText.text = "Health: " + health;
        healthSlider.value = health;
    }
}