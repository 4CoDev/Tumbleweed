using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials.FromSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<INatural>
{
	public SizeOfArray(IScalar<T[,,]> array) : base
	(
		new NaturalsFromInts32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}