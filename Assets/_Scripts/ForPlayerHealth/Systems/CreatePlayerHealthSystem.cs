using Entitas;

public class CreatePlayerHealthSystem : IInitializeSystem {
    private readonly GameContext _gameContext;

    public CreatePlayerHealthSystem(Contexts contexts) {
        _gameContext = contexts.game; 
    }

    public void Initialize() {
        var entity = _gameContext.CreateEntity();
        entity.AddPlayerHealth(100); 
    }
}