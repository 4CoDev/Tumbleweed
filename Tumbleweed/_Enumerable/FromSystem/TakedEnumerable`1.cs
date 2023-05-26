using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.FromSystem;

public sealed class TakedEnumerable<T> : EnumerableEnvelope<T>
{
	public TakedEnumerable
	(
		IEnumerable<T> enumerable,
		IScalar<Int32> elements
	) : base
	(
		new EnumerableOfScalar<T>(
			new ResultOfFunction<IEnumerable<T>>(
				() => enumerable.Take(elements.Value)))
	)
	{
	}
}