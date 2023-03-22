using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace Tumbleweed.Elements;

public sealed class ElementOfScalar<T> : IElement<T> where T : notnull
{
	public ElementOfScalar(IScalar<IElement<T>> scalar) =>
		this.scalar = scalar;
	
	public INullable<T> Value => scalar.Value.Value;

	public void Remove() => scalar.Value.Remove();

	public void Create(T value) => scalar.Value.Create(value);
	
	private readonly IScalar<IElement<T>> scalar;
}