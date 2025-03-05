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

    private void Start()
    {
        _healthBar.maxValue = _playerHealth.MaxHealthValue;
        _smoothHealthBar.maxValue = _playerHealth.MaxHealthValue;

        _smoothHealthBar.value = _playerHealth.CurrentHealth;
    }

    private void Update()
    {
        _healthText.text = $"{_playerHealth.CurrentHealth}/{_playerHealth.MaxHealthValue}";

        _healthBar.value = _playerHealth.CurrentHealth;

        float step = _smoothSpeed * Time.deltaTime;
        _smoothHealthBar.value = Mathf.MoveTowards(_smoothHealthBar.value, _playerHealth.CurrentHealth, step);
    }
}
