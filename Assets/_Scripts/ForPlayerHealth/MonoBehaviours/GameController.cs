using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour {
    private Systems _gameSystems;

    void Start() {
        var gameContexts = Contexts.sharedInstance;

        _gameSystems = new Feature("Player Health Feature")
            .Add(new PlayerHealthFeature(gameContexts)); 

        _gameSystems.Initialize();
    }

    void Update() {
        _gameSystems.Execute();
        _gameSystems.Cleanup();
    }
}