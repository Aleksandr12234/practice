using System;

namespace task04;

public class Fighter : ISpaceship
{
    public int Speed { get; } = 100;

    public int FirePower { get; } = 50;

    public void Fire()
    {
        //Истребитель стреляет на {FirePower} ед
    }

    public void MoveForward()
    {
        //Истребитель двигается на {Speed} ед
    }

    public void Rotate(int angle)
    {
        //Истребитель поворачивается на {angle} ед
    }
}
