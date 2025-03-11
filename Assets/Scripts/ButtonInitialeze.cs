using UnityEngine;

public class ButtonInitialeze : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private HealButton healButton;
    [SerializeField] private TakeDamageButton takeDamageButton;

    private void Start()
    {
        healButton.Initialize(playerHealth);
        takeDamageButton.Initialize(playerHealth);
    }
}
