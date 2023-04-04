using Tumbleweed.Nullability;

namespace Tumbleweed.Elements;

public interface IElement<T> where T : notnull
{
	INullable<T> Nullability { get; }

	void Remove();

	void Create(T value);
}