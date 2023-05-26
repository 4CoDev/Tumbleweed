using Tumbleweed.Mutable;

namespace Tumbleweed.Scalar;

public sealed class ValueOfMutable<T> : ScalarEnvelope<T>
{
	public ValueOfMutable(IMutable<T> mutable) : base
	(
		new ResultOfFunction<T>(
			() => mutable.Value)
	)
	{
	}
}