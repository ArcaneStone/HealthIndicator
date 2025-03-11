using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    public float MaxHealthValue => _maxHealth;

    public bool IsDead { get; private set; } = false;
    public float CurrentHealth { get; private set; }

    public event Action<float> OnHealthChanged;
    public event Action OnDeath;

    protected virtual void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    private void ChangeHealth(float amount)
    {
        if (amount == 0) return;

        float oldHealth = CurrentHealth;
        CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0, _maxHealth);

        if (CurrentHealth != oldHealth)
        {
            OnHealthChanged?.Invoke(CurrentHealth);
        }

        if (CurrentHealth <= 0 && !IsDead)
        {
            Die();
        }
    }

    public void TakeDamage(float damageAmount)
    {
        if (damageAmount < 0)
        {
            return;
        }
        ChangeHealth(-damageAmount);
    }

    public void Heal(float healAmount)
    {
        if (healAmount < 0)
        {
            return;
        }
        ChangeHealth(healAmount);
    }

    protected virtual void Die()
    {
        IsDead = true;
        OnDeath?.Invoke();
    }
}
