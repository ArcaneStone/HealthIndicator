using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBarUi : HealthUi
{
    [SerializeField] private Slider _smoothHealthBar;
    [SerializeField] private float _smoothSpeed = 35f;

    private float _targetSmoothHealth;

    private void Start()
    {
        _smoothHealthBar.maxValue = PlayerHealth.MaxHealthValue;
        _smoothHealthBar.value = PlayerHealth.CurrentHealth;
        _targetSmoothHealth = PlayerHealth.CurrentHealth;
    }

    protected override void UpdateHealthUI(float currentHealth)
    {
        _targetSmoothHealth = currentHealth;
    }

    private void LateUpdate()
    {
        if (_smoothHealthBar.value !=_targetSmoothHealth)
        {
            float step = _smoothSpeed * Time.deltaTime;
            _smoothHealthBar.value = Mathf.MoveTowards(_smoothHealthBar.value, _targetSmoothHealth, step);
        }
    }
}
