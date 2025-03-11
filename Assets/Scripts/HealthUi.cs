using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class HealthUi : MonoBehaviour
{
    [SerializeField] protected Health PlayerHealth;

    protected virtual void Start()
    {
        PlayerHealth.OnHealthChanged += UpdateHealthUI;
    }

    private void OnDestroy()
    {
        PlayerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    protected abstract void UpdateHealthUI(float currentHealth);
}
