using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private float _healAmount = 10f;

    public override void OnButtonClick()
    {
        PlayerHealth.Heal(_healAmount);
    }
}
