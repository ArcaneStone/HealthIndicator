using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private float _healAmount = 10f;

    public override void OnButtonClick()
    {
        _playerHealth.TakeDamage(-_healAmount);
    }
}
