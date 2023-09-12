using AuctionService.Entities;

namespace AuctionService.UnitTests;

public class AuctionEntityTests
{
    [Fact]
    public void HasReservePrices_ReservePriceGtZero_True()
    {
        var auction = new Auction
        {
            Id = Guid.NewGuid(),
            ReservePrice = 10
        };

        var result = auction.HasReservePrices();

        Assert.True(result);
    }

    [Fact]
    public void HasReservePrices_ReservePriceGtZero_False()
    {
        var auction = new Auction
        {
            Id = Guid.NewGuid(),
            ReservePrice = 0
        };

        var result = auction.HasReservePrices();

        Assert.False(result);
    }
}