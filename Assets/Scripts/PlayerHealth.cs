using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance { get; private set; }

    public event EventHandler OnPlayerDeath;

    [SerializeField] private float playerHealth = 10f;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one PlayerHealth! " + transform + "-" + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    private void Update()
    {
        if (playerHealth == 0)
        {
            OnPlayerDeath?.Invoke(this, EventArgs.Empty);
        }
    }

    public void RecieveDamage(float damage)
    {
        Debug.Log("Current Health: " + playerHealth);
        playerHealth -= damage;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            RecieveDamage(10);
        }
    }
}
