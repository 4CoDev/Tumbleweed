using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.Nested;

public sealed class Value<T> : Property::Envelope<T>
{
	public Value
	(
		Property::Any<Property::Any<T>> nested
	) : base
	(
		new Property::Function.Result.Actual<T>(
			() => nested.Value.Value)
	)
	{
	}
}