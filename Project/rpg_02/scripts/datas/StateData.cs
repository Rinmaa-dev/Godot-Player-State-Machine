using Godot;
using RPG_02.scripts.utils;

namespace RPG_02.scripts.datas;

public class StateData: IStateData
{
    public AnimatedSprite2D AnimatedSprite { get; }
    public CharacterBody2D CharacterBody { get; }
    public IStateMachine StateMachine { get; }
    
    public StateData(AnimatedSprite2D animatedSprite, CharacterBody2D characterBody, IStateMachine stateMachine)
    {
        this.AnimatedSprite = animatedSprite;
        this.CharacterBody = characterBody;
        this.StateMachine = stateMachine;
    }
    
    public void PrintData()
    {
        Godot.GD.Print(this.CharacterBody.Name);
        Godot.GD.Print(this.AnimatedSprite.Name);
    }
    
}