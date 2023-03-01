using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;

namespace Tumbleweed.Enumerables.Numerics.Integers;

public sealed class FlatIndexFromIndices : SignedEnvelope
{
	public FlatIndexFromIndices
	(
		IEnumerable<ISignedInteger> indices,
		IEnumerable<ISignedInteger> dimensions
	) : base
	(
		new SignedFromInt32(
			new ToSystem.FlatIndexFromIndices(indices, dimensions))
	)
	{
	}
}