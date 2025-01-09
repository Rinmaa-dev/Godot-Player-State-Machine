using RPG_02.scripts.utils;

public partial class IdleState : StateBase
{
    
    public override void Enter()
    {
        base.Enter();
        _data.AnimatedSprite.Play("Idle");
    }
    
    public override void StatePhysic(double delta)
    {
        
    }

    public override void StateInput(double delta)
    {
        if (InputServices.IsMovementPressed())
        {
            _data.StateMachine.ChageStateTo("Walk");
        }

        if (InputServices.IsAttackPressed())
        {
            _data.StateMachine.ChageStateTo("Attack");
        }
        
        if (InputServices.IsSneakPressed())
        {
            _data.StateMachine.ChageStateTo("Sneak");
        }
    }
}
