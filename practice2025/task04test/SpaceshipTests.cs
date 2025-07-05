using task04;

namespace task04test;

public class SpaceshipTests
{
    [Fact]
    public void Cruiser_ShouldHaveCorrectStats()
    {
        ISpaceship cruiser = new Cruiser();
        Assert.Equal(50, cruiser.Speed);
        Assert.Equal(100, cruiser.FirePower);
    }

    [Fact]
    public void Fighter_ShouldBeFasterThanCruiser()
    {
        var fighter = new Fighter();
        var cruiser = new Cruiser();
        Assert.True(fighter.Speed > cruiser.Speed);
    }

    [Fact]
    public void Fighter_ShouldHaveCorrectStats()
    {
        ISpaceship fighter = new Fighter();
        Assert.Equal(100, fighter.Speed);
        Assert.Equal(50, fighter.FirePower);
    }

    [Fact]
    public void Cruiser_ShouldBePowerThanCruiser()
    {
        var fighter = new Fighter();
        var cruiser = new Cruiser();
        Assert.True(fighter.FirePower < cruiser.FirePower);
    }

    [Fact]
    public void Cruiser_CheckFunction()
    {
        var cruiser = new Cruiser();
        try
        {
            cruiser.Fire();
            cruiser.MoveForward();
            cruiser.Rotate(10);
        }
        catch
        {
            Assert.True(false);
        }
        Assert.True(true);
    }

    [Fact]
    public void Fighter_CheckFunction()
    {
        var fighter = new Fighter();
        try
        {
            fighter.Fire();
            fighter.MoveForward();
            fighter.Rotate(10);
        }
        catch
        {
            Assert.True(false);
        }
        Assert.True(true);
    }
}
