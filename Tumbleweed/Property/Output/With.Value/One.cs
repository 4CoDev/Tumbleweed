using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.With.Value;

public sealed class One<T> : Property::Envelope<T>
{
	public One(T value) : base
	(
		new Property::Function.Result.Actual<T>(
			() => value)
	)
	{
	}
}