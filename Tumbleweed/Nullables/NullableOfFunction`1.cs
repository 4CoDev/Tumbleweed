using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullables;

public sealed class NullableOfFunction<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableOfFunction
	(
		Func<INullable<T>> function
	) : this
	(
		new FunctionFromSystem<INullable<T>>(function)
	)
	{
	}
	
	public NullableOfFunction
	(
		IFunction<INullable<T>> function
	) : base
	(
		new NullableOfScalar<T>(
			new ResultOfFunction<INullable<T>>(function))
	)
	{
	}
}