using Godot;

namespace RPG_02.scripts.utils;

public abstract partial class StateBase : Node2D, IState
{
    
    // dikelas abstract ini kita akan buat func yang memiliki tujuan sama disetiap state
    // contoh saya ingin func Enter() menampilkan log state yang saat ini aktif, apapun state nya fungsi dari func ini tidak berubah
    // berikutnya InjectData() apaun state nya func ini hanya memiliki satu tujuan, memasukan data ke wrapper.
    // beberapa func menggunakan virual agar dapat di override di kelas yang menjadi turunan kelas ini
    
    public IStateData _data { get; set; } // implement dari interface IState
    public string Nama { get; set; } //implement dari interface IState

    //setiap kali masuk ke dalam Tree, akan dijalankan
    public override void _Ready()
    {
        Nama = this.Name;
    }

    //print state saat ini
    public virtual void Enter()
    {
        GD.Print("=========================================");
        GD.Print("Masuk ke " + this.Name + " State");
        
    }

    public virtual void Exit()
    {
        throw new System.NotImplementedException();
    }

    public virtual void StateProses(double delta)
    {
        Godot.GD.Print("StateProses Not Implemanted yet");
    }

    public virtual void StatePhysic(double delta)
    {
        Godot.GD.Print("StatePhysic Not Implemanted yet");
    }

    public virtual void StateInput(double delta)
    {
        Godot.GD.Print("StateInput Not Implemanted yet");
    }

    
    //memasukan data ke dalam wrapper
    public virtual void InjectData(IStateData data)
    {
        _data = data;
    }
}