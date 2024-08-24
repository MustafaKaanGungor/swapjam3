using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Health health;
    [SerializeField] int damage;
    [SerializeField] Enemy rival;

    private void Awake() {
        health = GetComponent<Health>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AttackOpponent() {
        rival.GetComponent<Health>().Damage(damage);
    }
}
