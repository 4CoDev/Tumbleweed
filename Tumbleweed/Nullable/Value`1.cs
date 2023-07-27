using Tumbleweed.Scalar.Function;

namespace Tumbleweed.Nullable;

public sealed class Value<T> : Scalar.Envelope<T>
{
	public Value(Tumbleweed.Nullable.Any<T> any) : base
	(
		new Scalar.Function.Result<T>(
			() => any.Value)
	)
	{
	}
}