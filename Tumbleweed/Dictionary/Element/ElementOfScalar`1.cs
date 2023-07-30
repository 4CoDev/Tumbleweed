using Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Dictionary.Element;

public sealed class ElementOfScalar<T> : IDictionaryElement<T> where T : notnull
{
	public ElementOfScalar(Any<IDictionaryElement<T>> any) =>
		this.any = any;
	
	public Tumbleweed.Scalar.Nullable.Any<T> Nullability => any.Value.Nullability;

	public void Remove() => any.Value.Remove();

	public void Place(T value) => any.Value.Place(value);
	
	private readonly Any<IDictionaryElement<T>> any;
}