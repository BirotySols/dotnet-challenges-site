namespace InputTrust.Api;

public sealed class ListingStore
{
    private readonly object _gate = new();
    private readonly List<Listing> _listings = [];
    private int _nextId = 1;

    public Listing? Get(int id)
    {
        lock (_gate)
        {
            return _listings.FirstOrDefault(listing => listing.Id == id);
        }
    }

    public Listing Create(string title)
    {
        lock (_gate)
        {
            var listing = new Listing(_nextId++, title, 20m);
            _listings.Add(listing);
            return listing;
        }
    }

    public bool Replace(int id, string title)
    {
        lock (_gate)
        {
            var index = _listings.FindIndex(listing => listing.Id == id);
            if (index < 0)
            {
                return false;
            }

            var stored = _listings[index];
            _listings[index] = stored with { Title = title };
            return true;
        }
    }
}
