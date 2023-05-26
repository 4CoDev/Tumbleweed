using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable;

public sealed class EnumerableWithElement<T> : EnumerableEnvelope<T>
{
	public EnumerableWithElement
	(
		IEnumerable<T> enumerable,
		T element
	) : base
	(
		new EnumerableOfScalar<T>(
			new ResultOfFunction<IEnumerable<T>>(
				() => enumerable.Append(element)))
	)
	{
	}
}