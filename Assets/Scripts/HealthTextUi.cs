using UnityEngine;
using TMPro;

public class HealthTextUi : HealthUi
{
    [SerializeField] private TextMeshProUGUI _healthText;

    protected override void UpdateHealthUI(float currentHealth)
    {
        _healthText.text = $"{currentHealth}/{PlayerHealth.MaxHealthValue}";
    }
}
