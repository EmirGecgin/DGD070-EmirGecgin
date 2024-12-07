using Entitas;
using UnityEngine; 

public class CheckPlayerHealthSystem : IExecuteSystem {
    private readonly GameContext _gameContext;

    public CheckPlayerHealthSystem(Contexts contexts) {
        _gameContext = contexts.game; 
    }

    public void Execute() {
        var entities = _gameContext.GetEntities(GameMatcher.PlayerHealth);
        foreach (var e in entities) {
            
            if (e.isPlayerDamaged) {
                e.ReplacePlayerHealth(Mathf.Max(0, e.playerHealth.value - 10)); 
                e.isPlayerDamaged = false; 
            }

            
            if (e.isPlayerHealed) {
                e.ReplacePlayerHealth(Mathf.Min(100, e.playerHealth.value + 10)); 
                e.isPlayerHealed = false; 
            }
        }
    }
}