using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class HealthUi : MonoBehaviour
{
    [SerializeField] protected Health _playerHealth;

    protected virtual void Start()
    {
        _playerHealth.OnHealthChanged += UpdateHealthUI;
    }

    private void OnDestroy()
    {
        _playerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    protected abstract void UpdateHealthUI(float currentHealth);
}
