namespace Tumbleweed.Collection;

public sealed class CollectionOfFunction<T> : CollectionEnvelope<T>
{
	public CollectionOfFunction(Func<ICollection<T>> @delegate) : base
	(
		new CollectionOfScalar<T>(
			new Scalar.Function.Result<ICollection<T>>(@delegate))
	)
	{
	}
}