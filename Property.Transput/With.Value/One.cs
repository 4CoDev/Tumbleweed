using Property = Tumbleweed.Property.Transput;

namespace Tumbleweed.Property.Transput.With.Value;

public sealed class One<T> : Property::Any<T>
{
	public One(T value) =>
		Value = value;

	public T Value { get; set; }
}