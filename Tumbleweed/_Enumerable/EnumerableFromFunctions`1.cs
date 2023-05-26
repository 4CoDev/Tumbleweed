using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable;

public sealed class EnumerableOfFunctions<T> : EnumerableEnvelope<T>
{
	public EnumerableOfFunctions
	(
		params IScalar<Func<T>>[] functions
	) : this
	(
		new EnumerableWithElements<IScalar<Func<T>>>(functions)
	)
	{
	}
	
	public EnumerableOfFunctions
	(
		IEnumerable<IScalar<Func<T>>> functions
	) : this
	(
		new ValuesOfScalars<Func<T>>(functions)
	)
	{
	}

	public EnumerableOfFunctions
	(
		params Func<T>[] functions
	) : this
	(
		new EnumerableWithElements<Func<T>>(functions)
	)
	{
	}
	
	public EnumerableOfFunctions
	(
		IEnumerable<Func<T>> functions
	) : base
	(
		new ValuesOfScalars<T>(
			new SelectedByExpression<Func<T>, IScalar<T>>(
				functions,
				@delegate => new ResultOfFunction<T>(@delegate)))
	)
	{
	}
}