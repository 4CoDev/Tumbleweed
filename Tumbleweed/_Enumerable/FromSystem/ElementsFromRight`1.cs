using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.FromSystem;

public sealed class ElementsFromRight<T> : EnumerableEnvelope<T>
{
	public ElementsFromRight
	(
		IEnumerable<T> enumerable,
		IScalar<Int32> number
	) : base
	(
		new EnumerableOfScalar<T>(
			new ResultOfFunction<IEnumerable<T>>(
				() => enumerable.Skip(number.Value)))
	)
	{
	}
}