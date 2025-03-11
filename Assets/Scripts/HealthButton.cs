using UnityEngine;

public abstract class HealthButton : MonoBehaviour
{
    protected Health PlayerHealth;

    public void Initialize(Health health)
    {
        PlayerHealth = health;
    }

    public abstract void OnButtonClick();
}
