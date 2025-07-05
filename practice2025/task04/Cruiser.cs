
namespace task04;

public class Cruiser : ISpaceship
{
    public int Speed { get; } = 50;
    public int FirePower { get; } = 100;

    public void Fire()
    {
        //Крейсер стреляет на {FirePower} ед"
    }

    public void MoveForward()
    {
        //Крейсер двигается на {Speed} ед
    }

    public void Rotate(int angle)
    {
        //Крейсер поворачивается на {angle}
    }
}
