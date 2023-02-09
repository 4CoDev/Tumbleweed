using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.FromSystem;

namespace Tumbleweed.Enumerables.Numerics.Integers;

public sealed class FlatIndexFromIndices : IntegerEnvelope
{
	public FlatIndexFromIndices
	(
		IEnumerable<IInteger> indices,
		IEnumerable<IInteger> dimensions
	) : base
	(
		new IntegerFromInt32(
			new ToSystem.FlatIndexFromIndices(indices, dimensions))
	)
	{
	}
}