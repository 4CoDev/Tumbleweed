using Tumbleweed.Nullable;

namespace Tumbleweed.Storage.Element;

public interface IStorageElement<T>
{
	INullable<T> Nullable { get; }

	void Remove();

	void Place(T value);
}