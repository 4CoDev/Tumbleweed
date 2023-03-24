using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullability;

public sealed class NullableOfFunction<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableOfFunction
	(
		INullaryFunction<INullable<T>> function
	) : base
	(
		new NullableOfScalar<T>(
			new ValueOfFunction<INullable<T>>(function))
	)
	{
	}
}