using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Property.Output.Nested.Value;

public sealed class Actual<T> : Property::Envelope<T>
{
	public Actual
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