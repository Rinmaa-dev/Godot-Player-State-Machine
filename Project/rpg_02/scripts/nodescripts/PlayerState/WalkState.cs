using System;
using Godot;
using RPG_02.scripts.utils;

public partial class WalkState : StateBase
{
	
	[Export] float _speed = 5000.0f;

	public override void Enter()
	{
		base.Enter();
		_data.AnimatedSprite.Play("Walk");
		
	}

	public override void StatePhysic(double delta)
	{
		ArahCharacter();
		Vector2 velocity = Vector2.Zero;
		
		Vector2 direction = direction = InputServices.GetMovement();

		velocity = direction.Normalized() * _speed * (float)delta; 
		
		_data.CharacterBody.Velocity = velocity;

		_data.CharacterBody.MoveAndSlide();
	}
	
	public override void StateInput(double delta)
	{
		if (InputServices.IsMovementPressed() == false)
		{
			_data.StateMachine.ChageStateTo("Idle");
		}

		if (InputServices.IsRunPressed())
		{
			_data.StateMachine.ChageStateTo("Run");
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

	private void ArahCharacter()
	{
		
		Vector2 scale = _data.AnimatedSprite.Scale;
		if (InputServices.IsFaceRight)
		{
			scale.X = Math.Abs(scale.X);
		}
		else
		{
			scale.X = -Math.Abs(scale.X);
		}
		
		_data.AnimatedSprite.Scale = scale;
		
	}
}
