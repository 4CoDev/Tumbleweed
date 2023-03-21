using Tumbleweed.Nullability;

namespace Tumbleweed.Elements;

public interface IElement<T>
{
	INullable<T> Value { get; }

	void Remove();

	void Create(T value);
}