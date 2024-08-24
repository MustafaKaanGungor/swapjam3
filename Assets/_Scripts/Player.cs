using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Health health;
    [SerializeField] int damage;
    [SerializeField] Enemy rival;

    [SerializeField] Button attackButton;

    private void Awake() {
        health = GetComponent<Health>();
        GameManager.OnStateChanged += GameManagerOnStateChanged;
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

    private void GameManagerOnStateChanged(GameState state) {
        switch(state) {
            case GameState.GameStart:
            break;
            case GameState.PlayerTurn:
            break;
            case GameState.PlayerAction:
            break;
            case GameState.OpponentTurn:
            break;
            case GameState.OpoonentAction:
            break;
            case GameState.Victory:
            break;
            case GameState.Lose:
            break;
        }
    }
}
