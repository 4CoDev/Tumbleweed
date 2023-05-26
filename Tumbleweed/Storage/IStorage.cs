using Tumbleweed.Nullable;

namespace Tumbleweed.Storage;

public interface IStorage
{
	INullable<Object> ValueWith(Object key);
	
	void Add(Object key, Object value);
	
	void RemoveBy(Object key);
}