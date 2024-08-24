using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void Awake() {
        GameManager.OnStateChanged += GameManagerOnStateChanged;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
