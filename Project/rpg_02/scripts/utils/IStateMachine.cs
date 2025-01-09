using System.Collections.Generic;
namespace RPG_02.scripts.utils;

public interface IStateMachine
{
    
    void MachineProses(double delta); // untuk menjalankan proses setiap frame
    void MachinePhysic(double delta); // untuk menjalankan proses khusus yang berkaitan dengan physic setiap frame
    void MachineInput(double delta); // menampung setiap inputan yang ada di state
    
    void ChageStateTo(string stateName); // beralih state
    
    void InjectToState(IStateData data); // State 

}