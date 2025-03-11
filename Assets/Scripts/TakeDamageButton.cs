using UnityEngine;

public class TakeDamageButton : HealthButton
{
    [SerializeField] private float _damageAmount = 10f;

    public override void OnButtonClick()
    {
        PlayerHealth.TakeDamage(_damageAmount);
    }
}
