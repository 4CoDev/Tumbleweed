using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials.FromSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<IInteger>
{
	public SizeOfArray(IScalar<T[,,]> array) : base
	(
		new IntegersFromInts32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}