using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfDelegates<T> : EnumerableEnvelope<T>
{
	public EnumerableOfDelegates
	(
		params IScalar<Func<T>>[] delegates
	) : this
	(
		new EnumerableWithElements<IScalar<Func<T>>>(delegates)
	)
	{
	}
	
	public EnumerableOfDelegates
	(
		IEnumerable<IScalar<Func<T>>> delegates
	) : this
	(
		new ValuesOfScalars<Func<T>>(delegates)
	)
	{
	}

	public EnumerableOfDelegates
	(
		params Func<T>[] delegates
	) : this
	(
		new EnumerableWithElements<Func<T>>(delegates)
	)
	{
	}
	
	public EnumerableOfDelegates
	(
		IEnumerable<Func<T>> delegates
	) : base
	(
		new ValuesOfScalars<T>(
			new SelectedByExpression<Func<T>, IScalar<T>>(
				delegates,
				@delegate => new ValueOfDelegate<T>(@delegate)))
	)
	{
	}
}