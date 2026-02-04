
using Delegates;
 static void ShowPrice(int price)
{
    Console.WriteLine($"New price is: {price}");
}

StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
stockExchangeMonitor.PriceChangeHandler = ShowPrice;
stockExchangeMonitor.Start();

