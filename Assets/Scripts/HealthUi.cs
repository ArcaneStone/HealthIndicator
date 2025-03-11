using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class HealthUi : MonoBehaviour
{
    [SerializeField] protected Health PlayerHealth;

    protected virtual void OnEnable()
    {
        PlayerHealth.OnHealthChanged += UpdateHealthUI;
    }

    protected virtual void OnDisable()
    {
        PlayerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    protected abstract void UpdateHealthUI(float currentHealth);
}
