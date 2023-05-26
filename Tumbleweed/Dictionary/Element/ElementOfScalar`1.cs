using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Dictionary.Element;

public sealed class ElementOfScalar<T> : IDictionaryElement<T> where T : notnull
{
	public ElementOfScalar(IScalar<IDictionaryElement<T>> scalar) =>
		this.scalar = scalar;
	
	public INullable<T> Nullability => scalar.Value.Nullability;

	public void Remove() => scalar.Value.Remove();

	public void Place(T value) => scalar.Value.Place(value);
	
	private readonly IScalar<IDictionaryElement<T>> scalar;
}