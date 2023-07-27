// ReSharper disable once CheckNamespace

using Tumbleweed.Scalar.Function;

namespace Tumbleweed.Scalar.Of;

public sealed class Nested<T> : Envelope<T>
{
	public Nested(Any<Any<T>> nested) : base
	(
		new Function.Result<T>(
			() => nested.Value.Value)
	)
	{
	}
}