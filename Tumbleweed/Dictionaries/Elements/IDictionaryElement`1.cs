using Tumbleweed.Nullability;

namespace Tumbleweed.Dictionaries.Elements;

public interface IDictionaryElement<T> where T : notnull
{
	INullable<T> Nullability { get; }

	void Remove();

	void Place(T value);
}