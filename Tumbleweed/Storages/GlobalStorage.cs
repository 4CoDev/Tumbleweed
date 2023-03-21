namespace Tumbleweed.Storages;

public sealed class GlobalStorage : IStorage
{
	static GlobalStorage() =>
		Storage = new EmptyStorage();
	
	private static readonly IStorage Storage;

	public IDictionary<Object, Object> Records =>
		Storage.Records;
}