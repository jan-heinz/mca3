using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;

    public int currentHealth;
    public Slider healthSlider;
    
    
    
    // Start is called before the first frame update
    void Start() {
        currentHealth = startingHealth;
        healthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damageAmount) {
        if (currentHealth > 0) {
            currentHealth -= damageAmount;
            healthSlider.value = currentHealth;
        }
        if (currentHealth <= 0) {
            playerDies();
        }
        Debug.Log(currentHealth);
    }

    public void takeHealth(int healthAmount) {
        if (currentHealth < 100) {
            currentHealth += healthAmount;
            healthSlider.value = Mathf.Clamp(currentHealth, 0, 100);
        }
        Debug.Log(currentHealth);
    }

    void playerDies() {
        LevelManager levelManager = FindObjectOfType<LevelManager>();
        levelManager.LevelLost();
    }
}
