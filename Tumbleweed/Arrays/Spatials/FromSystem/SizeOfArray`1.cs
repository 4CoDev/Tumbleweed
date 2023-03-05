using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials.FromSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<INaturalInteger>
{
	public SizeOfArray(IScalar<T[,,]> array) : base
	(
		new NaturalsFromInts32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}