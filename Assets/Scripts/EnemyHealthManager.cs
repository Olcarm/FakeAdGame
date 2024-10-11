using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    [SerializeField] private TextMeshPro healthText;
    private int enemyHealth = 40;
    private void Start() {
        UpdateHealthText();
    }
    private void Update() {
        if(enemyHealth <= 0){
            Destroy(gameObject);
        }
    }

    public void RecieveDamage(int damage){
        enemyHealth -= damage;
        UpdateHealthText();
    }

    private void UpdateHealthText(){
        healthText.text = enemyHealth.ToString();
    }

}
