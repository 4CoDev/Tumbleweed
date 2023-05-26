using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.FromSystem.FromArray;

public sealed class EnumerableFromSpatial<T> : EnumerableEnvelope<T>
{
	public EnumerableFromSpatial
	(
		IScalar<T[,,]> array
	) : base
	(
		new EnumerableOfFunction<T>(array.Value.Cast<T>)
	)
	{
	}
}