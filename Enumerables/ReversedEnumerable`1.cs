namespace Tumbleweed.Enumerables;

public sealed class ReversedEnumerable<T> : EnumerableEnvelope<T>
{
	public ReversedEnumerable(IEnumerable<T> origin) : base
	(
		new EnumerableOfScalar<T>(
			new Scalar.ReversedEnumerable<T>(origin))
	)
	{
	}
}