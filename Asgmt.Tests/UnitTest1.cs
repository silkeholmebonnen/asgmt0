namespace Asgmt.Tests;


public class UnitTest1
{
    [Fact]
    public void Eight_is_divisible_by_four()
    {
        // arrange
        var sut = new Program();

        // act
        var result = sut.IsLeapYear(8);

        // assert
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

    [Fact]
    public void if_leapyear_output_yay()
    {
        var sut = new Program();

        var result = sut.yayOrNay(true);

        result.Should().Be("yay");
    }

    [Fact]
    public void if_not_leapyear_output_nay()
    {
        var sut = new Program();

        var result = sut.yayOrNay(false);

        result.Should().Be("nay");
    }
}