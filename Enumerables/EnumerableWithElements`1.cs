namespace Tumbleweed.Enumerables;

public sealed class EnumerableWithElements<T> : EnumerableEnvelope<T>
{
	public EnumerableWithElements
	(
		IEnumerable<IEnumerable<T>> enumerables
	) : base
	(
		new EnumerableOfScalar<T>(
			new Scalar.EnumerableWithElements<T>(enumerables))
	)
	{
	}
}