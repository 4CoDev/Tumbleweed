using Tumbleweed.Nullable;

namespace Tumbleweed.Dictionary.Element;

public interface IDictionaryElement<T> where T : notnull
{
	INullable<T> Nullability { get; }

	void Remove();

	void Place(T value);
}