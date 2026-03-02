using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    [SerializeField] int health;
    [SerializeField] private GameObject gameOverPanel;

    public HealthBar healthBar;

    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int  damage)
    {
        health -= damage;

        if(health <= 0)
        {
            gameOverPanel.SetActive(true);
            Destroy(gameObject);
        }

        healthBar.SetHealth(health);
    }
}