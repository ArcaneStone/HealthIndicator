using UnityEngine;

public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] protected Health _playerHealth;

    public abstract void OnButtonClick();
}
