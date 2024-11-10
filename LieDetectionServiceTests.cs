// Unit test for LieDetectionService
using LieDetectorWebApp.Tests;
using Xunit;

public class LieDetectionServiceTests
{
    [Fact]
    public void IsDeceptive_ReturnsTrue_WhenHeartRateAndGsrAreHigh()
    {
        // Arrange
        var service = new LieDetectionService();

        // Act
        var result = service.IsDeceptive(120, 15);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsDeceptive_ReturnsFalse_WhenHeartRateIsLow()
    {
        // Arrange
        var service = new LieDetectionService();

        // Act
        var result = service.IsDeceptive(80, 15);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsDeceptive_ReturnsFalse_WhenGsrIsLow()
    {
        // Arrange
        var service = new LieDetectionService();

        // Act
        var result = service.IsDeceptive(120, 5);

        // Assert
        Assert.False(result);
    }
}
