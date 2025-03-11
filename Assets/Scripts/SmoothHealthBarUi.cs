using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBarUi : HealthUi
{
    [SerializeField] private Slider _smoothHealthBar;
    [SerializeField] private float _smoothSpeed = 35f;

    private float _targetSmoothHealth;

    protected override void Start()
    {
        base.Start();

        _smoothHealthBar.maxValue = PlayerHealth.MaxHealthValue;
        _smoothHealthBar.value = PlayerHealth.CurrentHealth;
        _targetSmoothHealth = PlayerHealth.CurrentHealth;
    }

    private void Update()
    {
        float step = _smoothSpeed * Time.deltaTime;
        _smoothHealthBar.value = Mathf.MoveTowards(_smoothHealthBar.value, _targetSmoothHealth, step);
    }

    protected override void UpdateHealthUI(float currentHealth)
    {
        _targetSmoothHealth = currentHealth;
    }
}
