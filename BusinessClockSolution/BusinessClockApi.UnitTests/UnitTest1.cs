namespace BusinessClockApi.UnitTests;



public class BusinessClockTests
{
    [Fact]
    public void ClosedOnSaturday()
    {

        var clock = new BusinessClock();



        bool isOpen = clock.IsOpen();



        Assert.False(isOpen);

    }



    [Fact]
    public void ClosedOnSunday()
    {



    }
}