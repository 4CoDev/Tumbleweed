using Tumbleweed.Property.Nullable;

namespace Tumbleweed.Dictionary.Element;

public interface IDictionaryElement<T> where T : notnull
{
	Any<T> Nullability { get; }

	void Remove();

	void Place(T value);
}