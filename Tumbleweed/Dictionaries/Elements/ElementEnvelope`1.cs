using Tumbleweed.Nullability;

namespace Tumbleweed.Dictionaries.Elements;

public abstract class ElementEnvelope<T> : IDictionaryElement<T> where T : notnull
{
	protected ElementEnvelope(IDictionaryElement<T> element) =>
		this.element = element;

	public override Boolean Equals(Object? @object) =>
		element.Equals(@object);

	public override Int32 GetHashCode() =>
		element.GetHashCode();

	public override String? ToString() =>
		element.ToString();

	public INullable<T> Nullability => element.Nullability;

	public void Remove() => element.Remove();

	public void Place(T value) => element.Place(value);
	
	private readonly IDictionaryElement<T> element;
}