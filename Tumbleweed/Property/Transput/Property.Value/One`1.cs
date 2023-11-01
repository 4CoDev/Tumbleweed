using Property = Tumbleweed.Property;

namespace Tumbleweed.Property.Transput.Property.Value;

public sealed class One<T> : Property::Transput.Any<T>
{
	public One(Property::Output.Any<Property::Transput.Any<T>> property) =>
		this.property = property;

	public T Value
	{
		get => property.Value.Value;
		set => property.Value.Value = value;
	}

	private readonly Property::Output.Any<Property::Transput.Any<T>> property;
}