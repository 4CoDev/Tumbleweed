using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace Tumbleweed.Mutable;

public sealed class Value<T> : Scalar.Envelope<T>
{
	public Value(Any<T> mutable) : base
	(
		new Scalar.Function.Result<T>(
			() => mutable.Value)
	)
	{
	}
}