namespace Tumbleweed.Enumerables;

public sealed class EnumerableWithElements<T> : EnumerableEnvelope<T>
{
	public EnumerableWithElements(params T[] elements) : this
	(
		new EnumerableOfDelegate<T>(elements.AsEnumerable)
	)
	{
	}
	
	public EnumerableWithElements(params IEnumerable<T>[] elements) : this
	(
		new EnumerableOfDelegate<IEnumerable<T>>(elements.AsEnumerable)
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