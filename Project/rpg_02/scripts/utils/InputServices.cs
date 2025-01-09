using Godot;


namespace RPG_02.scripts.utils;

public partial class InputServices : Node
{
    
    /*Kelas ini menampung semua Inputan dan bagaimana Inputan dikombinasikan.
    sayangnya godot tidak memiliki func lengkap untuk berbagai macam bentuk inputan*/
    
    
    //untuk menetukan apakah character menghadap kanan atau kiri
    public static bool IsFaceRight ;
    
    // mendapatkan arah Inputan Gerak
    public static Vector2 GetMovement()
    {
        
        Vector2 movement = new Vector2();
        
        if (Input.IsActionPressed("Kiri"))
        {
            movement.X = -1;
            IsFaceRight = false;
            
        }
        if (Input.IsActionPressed("Kanan"))
        {
            movement.X = 1;
            IsFaceRight = true;
            
        }
        if (Input.IsActionPressed("Atas"))
        {
            movement.Y = -1;
        }
        if (Input.IsActionPressed("Bawah"))
        {
            movement.Y = 1;
        }
        
        return movement;
    }

    // mencek apakah tombol Inputan gerak ditekan atau tidak
    public static bool IsMovementPressed()
    {
        if (Input.GetVector("Kiri","Kanan","Atas","Bawah") != Vector2.Zero)
        {
            return true;
        }
        
        return false;
    }

    // Mencek apakah tombol Run ditekan
    public static bool IsRunPressed()
    {
        if (Input.IsActionPressed("Run"))
        {
            return true;
        }
        return false;
    }

    //mencek apakah Tombol Attack ditekan
    public static bool IsAttackPressed()
    {
        if (Input.IsActionJustPressed("Attack"))
        {
            return true;
        }
        
        return false;
    }
    
    // mencek apakah tombol Sneak ditekan
    public static bool IsSneakPressed()
    {
        if (Input.IsActionJustPressed("Sneak"))
        {
            return true;
        }
        
        return false;
    }
}