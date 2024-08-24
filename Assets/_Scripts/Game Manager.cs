using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState state;

    public static event Action<GameState> OnStateChanged;
    private void Awake() {
        Instance = this;
    }

    private void Start() {
        UpdateGameState(GameState.GameStart);
    }

    public void SetGameState(int number) {
        switch (number)
        {
            case 1:
            UpdateGameState(GameState.GameStart);
            break;
            case 2:
            UpdateGameState(GameState.PlayerTurn);
            break;
            case 3:
            UpdateGameState(GameState.PlayerAction);
            break;
            case 4:
            UpdateGameState(GameState.OpponentTurn);
            break;
            case 5:
            UpdateGameState(GameState.OpoonentAction);
            break;
            case 6:
            UpdateGameState(GameState.Victory);
            break;
            case 7:
            UpdateGameState(GameState.Lose);
            break;
            default:
            Debug.Log("hatali sayi");
            break;
        }
    }

    public void UpdateGameState(GameState newState) {
        state = newState;

        switch(newState) {
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

        OnStateChanged?.Invoke(newState);

    }
}

public enum GameState {
    GameStart,
    PlayerTurn,
    PlayerAction,
    OpponentTurn,
    OpoonentAction,
    Victory,
    Lose
}
