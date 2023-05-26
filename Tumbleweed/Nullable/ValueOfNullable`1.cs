using Tumbleweed.Scalar;

namespace Tumbleweed.Nullable;

public sealed class ValueOfNullable<T> :
	ScalarEnvelope<T>
{
	public ValueOfNullable(INullable<T> nullable) : base
	(
		new ResultOfFunction<T>(
			() => nullable.Value)
	)
	{
	}
}