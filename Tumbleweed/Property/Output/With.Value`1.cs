using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.With;

public sealed class Value<T> : Property::Envelope<T>
{
	public Value(T value) : base
	(
		new Property::Function.Result.Actual<T>(
			() => value)
	)
	{
	}
}