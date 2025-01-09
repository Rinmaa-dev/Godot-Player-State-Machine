using Godot;
using RPG_02.scripts.datas;
using RPG_02.scripts.utils;

public partial class Player : CharacterBody2D
{

	private AnimatedSprite2D _animation;
	private IStateMachine _stateMachine;
	
	private StateData _stateData;

	public override void _Ready()
	{
		_animation = GetNode<AnimatedSprite2D>("PlayerAnimatedSprite2D");
		_stateMachine = GetNode<IStateMachine>("StateMachine");
		
		// membuat object yang menjadi wadah untuk setiap state
		_stateData = new StateData(_animation, this, _stateMachine);
		
		//inject data ke setiap state
		_stateMachine.InjectToState(_stateData);
		
		//saat pertama dijalankan kita akan masuk ke idle state
		_stateMachine.ChageStateTo("Idle");
	}

	public override void _PhysicsProcess(double delta)
	{
		_stateMachine.MachinePhysic(delta);
		
	}

	public override void _Process(double delta)
	{
		_stateMachine.MachineInput(delta);
	}
}
