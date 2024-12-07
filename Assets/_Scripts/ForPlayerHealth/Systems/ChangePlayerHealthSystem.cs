using Entitas;
using UnityEngine;

public class ChangePlayerHealthSystem : IExecuteSystem {
    private readonly GameContext _gameContext;

    public ChangePlayerHealthSystem(Contexts contexts) {
        _gameContext = contexts.game; 
    }

    public void Execute() {
        var entities = _gameContext.GetEntities(GameMatcher.PlayerHealth);
        foreach (var e in entities) {
            if (Input.GetKeyDown(KeyCode.D)) {
                e.isPlayerDamaged = true; 
            }

            if (Input.GetKeyDown(KeyCode.H)) {
                e.isPlayerHealed = true; 
            }
        }
    }
}