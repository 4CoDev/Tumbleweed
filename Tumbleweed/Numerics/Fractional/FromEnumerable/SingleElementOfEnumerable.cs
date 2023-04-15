using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Fractional.FromEnumerable;

public sealed class SingleElementOfEnumerable : FractionalEnvelope
{
	public SingleElementOfEnumerable(IEnumerable<IFractional> enumerable) : base
	(
		new FractionalOfScalar(
			new SingleOfEnumerable<IFractional>(enumerable))
	)
	{
	}
}