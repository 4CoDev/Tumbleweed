using Property = Tumbleweed.Property.Transput;
using System = System;

namespace Tumbleweed.Property.Transput;

public abstract class Envelope<T> : Property::Any<T>
{
	protected Envelope(Property::Any<T> property) =>
		this.property = property;

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		property.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		property.GetHashCode();

	public override System::String? ToString() =>
		property.ToString();

	public T Value
	{
		get => property.Value;
		set => property.Value = value;
	}

	private readonly Property::Any<T> property;
}