using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float MaxHealth;

    public bool IsDead { get; protected set; } = false;
    public float CurrentHealth { get; protected set; }

    public event System.Action<float> OnHealthChanged;
    public event System.Action OnDeath;

    public float MaxHealthValue => MaxHealth;

    protected virtual void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        float oldHealth = CurrentHealth;
        CurrentHealth = Mathf.Clamp(CurrentHealth - damageAmount, 0, MaxHealth);

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
