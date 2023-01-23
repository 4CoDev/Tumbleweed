using Tumbleweed.Scalars;

namespace Tumbleweed.WithSystem.Numerics.Ints32;

public class DifferenceOf2Numbers : ScalarEnvelope<int>
{
	public DifferenceOf2Numbers(IScalar<int> left, IScalar<int> right) : base
	(
		new ScalarOfDelegate<int>(
			() => left.Value() - right.Value())
	)
	{
	}
}