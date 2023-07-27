namespace Tumbleweed.Dictionary.Element;

public sealed class ElementOfScalar<T> : IDictionaryElement<T> where T : notnull
{
	public ElementOfScalar(Tumbleweed.Scalar.Any<IDictionaryElement<T>> any) =>
		this.any = any;
	
	public Nullable.Any<T> Nullability => any.Value.Nullability;

	public void Remove() => any.Value.Remove();

	public void Place(T value) => any.Value.Place(value);
	
	private readonly Tumbleweed.Scalar.Any<IDictionaryElement<T>> any;
}