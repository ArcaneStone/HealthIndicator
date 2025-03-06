using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthUi : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _healthText;
    [SerializeField] Slider _healthBar;
    [SerializeField] Slider _smoothHealthBar;

    [SerializeField] private float _smoothSpeed = 35f;

    [SerializeField] private Health _playerHealth;

    private float _targetSmoothHealth;

    private void Start()
    {
        _healthBar.maxValue = _playerHealth.MaxHealthValue;
        _smoothHealthBar.maxValue = _playerHealth.MaxHealthValue;

        _healthBar.value = _playerHealth.CurrentHealth;
        _smoothHealthBar.value = _playerHealth.CurrentHealth;
        _targetSmoothHealth = _playerHealth.CurrentHealth;

        _playerHealth.OnHealthChanged += UpdateHealthUI;
    }

    private void OnDestroy()
    {
        _playerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    private void Update()
    {
        float step = _smoothSpeed * Time.deltaTime;

        _smoothHealthBar.value = Mathf.MoveTowards(_smoothHealthBar.value, _targetSmoothHealth, step);
    }

    private void UpdateHealthUI(float currentHealth)
    {
        _healthText.text = $"{currentHealth}/{_playerHealth.MaxHealthValue}";

        _healthBar.value = currentHealth;

        _targetSmoothHealth = currentHealth;
    }
}
