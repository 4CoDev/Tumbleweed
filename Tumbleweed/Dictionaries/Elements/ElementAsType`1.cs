using Tumbleweed.Nullability;

namespace Tumbleweed.Dictionaries.Elements;

public sealed class ElementAsType<T> : IDictionaryElement<T> where T : notnull
{
	public ElementAsType(IDictionaryElement<Object> origin) =>
		this.origin = origin;
	
	public INullable<T> Nullability =>
		new NullableAsType<T>(origin.Nullability);

	public void Remove() => origin.Remove();

	public void Place(T value) => origin.Place(value);
	
	private readonly IDictionaryElement<Object> origin;
}