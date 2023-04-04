using Tumbleweed.Scalars;

namespace Tumbleweed.Nullability;

public sealed class ValueOfNullable<T> :
	ScalarEnvelope<T>
	where T : notnull
{
	public ValueOfNullable(INullable<T> nullable) : base
	(
		new ValueOfFunction<T>(
			() => nullable.Value)
	)
	{
	}
}