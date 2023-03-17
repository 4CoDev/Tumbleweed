using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem.FromArray;

public sealed class EnumerableFromPlanar<T> : EnumerableEnvelope<T>
{
	public EnumerableFromPlanar
	(
		IScalar<T[,]> array
	) : base
	(
		new EnumerableOfFunction<T>(array.Value.Cast<T>)
	)
	{
	}
}