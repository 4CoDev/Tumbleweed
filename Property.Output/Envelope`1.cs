using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Property.Output;

public abstract class Envelope<T> : Property::Any<T>
{
	protected Envelope(Property::Any<T> property) =>
		this.property = property;

	public T Value => property.Value;

	public override System::Boolean Equals
	(
		System::Object? other
	) =>
	(
		property.Equals(other)
	);

	public override System::Int32 GetHashCode() =>
		property.GetHashCode();

	public override System::String? ToString() =>
		property.ToString();

	private readonly Property::Any<T> property;
}