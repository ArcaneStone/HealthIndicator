using UnityEngine;

public class HealthTest : MonoBehaviour
{
    [SerializeField] private Health _playerHealth;
    [SerializeField] private HealthUi _healthUi;

    public void TakeDamageButton()
    {
        _playerHealth.TakeDamage(10f);
    }

    public void HealButton()
    {
        _playerHealth.TakeDamage(-10f);
    }
}
