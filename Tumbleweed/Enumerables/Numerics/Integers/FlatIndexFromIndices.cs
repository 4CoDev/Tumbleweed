using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;

namespace Tumbleweed.Enumerables.Numerics.Integers;

public sealed class FlatIndexFromIndices : NaturalEnvelope
{
	public FlatIndexFromIndices
	(
		IEnumerable<INaturalInteger> indices,
		IEnumerable<INaturalInteger> dimensions
	) : base
	(
		new NaturalFromInt32(
			new ToSystem.FlatIndexFromIndices(indices, dimensions))
	)
	{
	}
}