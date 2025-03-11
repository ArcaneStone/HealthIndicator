using UnityEngine;

public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] protected Health PlayerHealth;

    public abstract void OnButtonClick();
}
