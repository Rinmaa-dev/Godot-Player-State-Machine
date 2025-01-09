using Godot;
using System;
using RPG_02.scripts.utils;

public partial class AttackState : StateBase
{

	private int _attackSequence = 1;
	
	public override void Enter()
	{
		base.Enter();
		if (_attackSequence == 1)
		{
			_data.AnimatedSprite.Play("Attack_1");
			_attackSequence += 1;
		}
		else if (_attackSequence == 2)
		{
			_data.AnimatedSprite.Play("Attack_2");
			_attackSequence = 1;
		}
	}

	public override void StatePhysic(double delta)
	{
		
	}

	public override void StateInput(double delta)
	{
		if (_data.AnimatedSprite.Animation == "Attack_1" || _data.AnimatedSprite.Animation == "Attack_2")
		{
			if (_data.AnimatedSprite.Frame == 6)
			{
				_data.StateMachine.ChageStateTo("Idle");			}
		}
		
	}
}
