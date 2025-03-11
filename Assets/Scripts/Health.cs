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

    public void TakeDamage(float damageAmount)
    {
        float oldHealth = CurrentHealth;
        CurrentHealth = Mathf.Clamp(CurrentHealth - damageAmount, 0, _maxHealth);

        if (CurrentHealth != oldHealth)
        {
            OnHealthChanged?.Invoke(CurrentHealth);
        }

        if (CurrentHealth <= 0 && !IsDead)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        IsDead = true;
        OnDeath?.Invoke();
    }
}
