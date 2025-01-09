using Godot;
using System;
using RPG_02.scripts.utils;

public partial class SneakState : StateBase
{
	[Export] float _speed = 2500.0f;

	public override void Enter()
	{
		base.Enter();
		_data.AnimatedSprite.Play("Sneak");
		
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
		
		if (InputServices.IsSneakPressed())
		{
			_data.StateMachine.ChageStateTo("Idle");
		}
		
		if (InputServices.IsAttackPressed())
		{
			_data.StateMachine.ChageStateTo("Attack");
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
