using UnityEngine;
using UnityEngine.UI;

public class HealthBarUi : HealthUi
{
    [SerializeField] private Slider _healthBar;

    private void Start()
    {
        _healthBar.maxValue = PlayerHealth.MaxHealthValue;
        _healthBar.value = PlayerHealth.CurrentHealth;
    }

    protected override void UpdateHealthUI(float currentHealth)
    {
        _healthBar.value = currentHealth;
    }
}
