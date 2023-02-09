using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Numerics.Integers.ToSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<int>
{
	public FlatIndexFromIndices
	(
		IEnumerable<IInteger> indices,
		IEnumerable<IInteger> dimensions
	) : base
	(
		new OfSystem.FlatIndexFromIndices(
			new Ints32FromIntegers(indices),
			new Ints32FromIntegers(dimensions))
	)
	{
	}
}