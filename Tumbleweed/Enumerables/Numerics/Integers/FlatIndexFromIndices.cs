using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.FromSystem;

namespace Tumbleweed.Enumerables.Numerics.Integers;

public sealed class FlatIndexFromIndices : NaturalEnvelope
{
	public FlatIndexFromIndices
	(
		IEnumerable<INatural> indices,
		IEnumerable<INatural> dimensions
	) : base
	(
		new NaturalFromInt32(
			new ToSystem.FlatIndexFromIndices(indices, dimensions))
	)
	{
	}
}