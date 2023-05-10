using Tumbleweed.Nullables;

namespace Tumbleweed.Storages;

public sealed class GlobalStorage : IStorage
{
	static GlobalStorage() =>
		Storage = new EmptyStorage();

	public INullable<Object> ValueWith(Object key) =>
		Storage.ValueWith(key);

	public void Add(Object key, Object value) =>
		Storage.Add(key, value);
	
	public void RemoveBy(Object key) =>
		Storage.RemoveBy(key);
	
	private static readonly IStorage Storage;
}