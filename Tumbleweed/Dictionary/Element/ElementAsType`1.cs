using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.As;
using System = System;

namespace Tumbleweed.Dictionary.Element;

public sealed class ElementAsType<T> : IDictionaryElement<T> where T : notnull
{
	public ElementAsType(IDictionaryElement<System::Object> origin) =>
		this.origin = origin;
	
	public Any<T> Nullability =>
		new Type<T>(origin.Nullability);

	public void Remove() => origin.Remove();

	public void Place(T value) => origin.Place(value);
	
	private readonly IDictionaryElement<System::Object> origin;
}