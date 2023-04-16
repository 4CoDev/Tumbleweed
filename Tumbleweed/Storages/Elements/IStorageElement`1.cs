using Tumbleweed.Nullability;

namespace Tumbleweed.Storages.Elements;

public interface IStorageElement<T>
{
	INullable<T> Nullable { get; }

	void Remove();

	void Place(T value);
}