using Godot;
using System;
using System.Collections.Generic;
using RPG_02.scripts.utils;

public partial class StateMachine : Node2D, IStateMachine
{
    
    private IState _currentState;
    private Dictionary<string, IState> _states = new Dictionary<string, IState>();
    
    
    //panggi func ini di _proses
    public void MachineProses(double delta)
    {
        _currentState.StateProses(delta);
    }

    //panggil func ini di _physicProses 
    public void MachinePhysic(double delta)
    {
        _currentState.StatePhysic(delta);
    }

    //func ini boleh dimasukan dimana saja, disaran kan untuk dimasukan di _proses
    public void MachineInput(double delta)
    {
        _currentState.StateInput(delta);
    }

    //func untuk mengganti state 
    public void ChageStateTo(string stateName)
    {
        _currentState = _states[stateName];
        _currentState.Enter();
    }

    
    //func ini memiliki 2 tangugng jawab, mengambil setiap state yang ada dan inject data yang dibutuhkan setiap state
    public void InjectToState(IStateData data)
    {
        foreach (IState state in this.GetChildren())
        {
            state.InjectData(data);
            _states.Add(state.Nama, state);
        }
    }
}
