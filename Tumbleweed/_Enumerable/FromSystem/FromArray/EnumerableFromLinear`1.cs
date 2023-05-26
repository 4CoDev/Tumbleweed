using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.FromSystem.FromArray;

public sealed class EnumerableFromLinear<T> : EnumerableEnvelope<T>
{
	public EnumerableFromLinear
	(
		IScalar<T[]> array
	) : base
	(
		new EnumerableOfFunction<T>(array.Value.AsEnumerable)
	)
	{
	}
}