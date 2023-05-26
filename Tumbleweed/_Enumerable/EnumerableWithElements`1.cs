namespace Tumbleweed._Enumerable;

public sealed class EnumerableWithElements<T> : EnumerableEnvelope<T>
{
	public EnumerableWithElements(params T[] elements) : this
	(
		new EnumerableOfFunction<T>(elements.AsEnumerable)
	)
	{
	}
	
	public EnumerableWithElements(params IEnumerable<T>[] elements) : this
	(
		new EnumerableOfFunction<IEnumerable<T>>(elements.AsEnumerable)
	)
	{
	}
	
	public EnumerableWithElements
	(
		IEnumerable<IEnumerable<T>> elements
	) : base
	(
		new EnumerableOfScalar<T>(
			new Scalar.EnumerableWithElements<T>(elements))
	)
	{
	}
}