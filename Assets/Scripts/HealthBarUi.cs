using UnityEngine;
using UnityEngine.UI;

public class HealthBarUi : HealthUi
{
    [SerializeField] private Slider _healthBar;

    protected override void Start()
    {
        base.Start();

        _healthBar.maxValue = _playerHealth.MaxHealthValue;
        _healthBar.value = _playerHealth.CurrentHealth;
    }

    protected override void UpdateHealthUI(float currentHealth)
    {
        _healthBar.value = currentHealth;
    }
}
