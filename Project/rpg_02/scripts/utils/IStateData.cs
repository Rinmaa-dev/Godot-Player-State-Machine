using Godot;

namespace RPG_02.scripts.utils;

public interface IStateData
{
    AnimatedSprite2D AnimatedSprite { get; }
    CharacterBody2D CharacterBody { get; }
    IStateMachine StateMachine { get; }

    void PrintData();

}