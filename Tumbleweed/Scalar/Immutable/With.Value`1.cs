using Immutable = Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.With;

public sealed class Value<T> : Immutable::Envelope<T>
{
	public Value(T value) : base
	(
		new Immutable::Function.Result.Actual<T>(
			() => value)
	)
	{
	}
}