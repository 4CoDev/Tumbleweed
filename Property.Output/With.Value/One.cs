using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.With.Value;

public sealed class One<T> : Property::Any<T>
{
	public One(T value) =>
		this.value = value;

	public T Value => value;
	
	private readonly T value;
}