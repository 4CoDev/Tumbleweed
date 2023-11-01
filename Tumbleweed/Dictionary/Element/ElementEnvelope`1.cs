using Tumbleweed.Property.Nullable;
using System = System;

namespace Tumbleweed.Dictionary.Element;

public abstract class ElementEnvelope<T> : IDictionaryElement<T> where T : notnull
{
	protected ElementEnvelope(IDictionaryElement<T> element) =>
		this.element = element;

	public override System::Boolean Equals(System::Object? @object) =>
		element.Equals(@object);

	public override Int32 GetHashCode() =>
		element.GetHashCode();

	public override System::String? ToString() =>
		element.ToString();

	public Any<T> Nullability => element.Nullability;

	public void Remove() => element.Remove();

	public void Place(T value) => element.Place(value);
	
	private readonly IDictionaryElement<T> element;
}