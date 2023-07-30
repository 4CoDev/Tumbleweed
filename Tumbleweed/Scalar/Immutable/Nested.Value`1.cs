using Immutable = Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.Nested;

public sealed class Value<T> : Immutable::Envelope<T>
{
	public Value
	(
		Immutable::Any<Immutable::Any<T>> nested
	) : base
	(
		new Immutable::Function.Result.Actual<T>(
			() => nested.Value.Value)
	)
	{
	}
}