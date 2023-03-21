namespace Tumbleweed.Storages;

public interface IStorage
{
	IDictionary<Object, Object> Records { get; }
}