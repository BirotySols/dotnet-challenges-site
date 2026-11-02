namespace InputTrust.Api;

public sealed record Listing(int Id, string Title, decimal Price);

public sealed record ListingWrite(string Title);
