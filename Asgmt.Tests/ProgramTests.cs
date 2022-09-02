namespace Asgmt.Tests;


public class UnitTest1
{
    [Fact]
    public void Eight_is_divisible_by_four()
    {
        var sut = new Program();

        var result = sut.IsLeapYear(8);

        result.Should().Be(true);
    }

    [Fact]
    public void Nine_is_not_divisible_by_four()
    {
        var sut = new Program();

        var result = sut.IsLeapYear(9);

        result.Should().Be(false);
    }

    [Fact]
    public void hundred_is_not_leapyear()
    {
        var sut = new Program();

        var result = sut.IsLeapYear(100);

        result.Should().Be(false);
    }

    [Fact]
    public void twothousand_is_leapyear()
    {
        var sut = new Program();

        var result = sut.IsLeapYear(2000);

        result.Should().Be(true);
    }

    [Fact]
    public void seventeenhundred_is_not_leapyear()
    {
        var sut = new Program();

        var result = sut.IsLeapYear(1700);

        result.Should().Be(false);
    }
}