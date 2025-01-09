namespace RPG_02.scripts.utils;

public interface IState
{
    IStateData _data { get; set; } // data wrapper yang penting untuk setiap state
    
    string Nama { set; get; } // untuk menampung Nama yang diambil dari Node2D
    
    void Enter(); // akan dipanggil setiap masuk state baru
    void Exit(); // opsinoal,
    void StateProses(double delta); // mengatur proses setiap frame
    void StatePhysic(double delta); // mengatur physic setiap frame
    void StateInput(double delta); // menampung setiap inputan
    
    void InjectData(IStateData data); // memasukan data yang di inject ke dalam object wrapper
    
    
}