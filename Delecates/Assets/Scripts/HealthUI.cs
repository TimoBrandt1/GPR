using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthUI : MonoBehaviour
{
    private PlayerHealth playerHealth;
    [SerializeField] Text healthText;
    // Start is called before the first frame update
    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        playerHealth.ChangeHealth += ChangeHealthUI;
        playerHealth.Die += OnDie;
    }

    private void ChangeHealthUI(int health)
    {
        healthText.text = "Health: " + health;
    }
    private void OnDie()
    {
        healthText.text = "You are dead";
    }

}
