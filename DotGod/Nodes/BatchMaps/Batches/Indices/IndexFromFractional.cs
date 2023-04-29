using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;

namespace DotGod.Nodes.BatchMaps.Batches.Indices;

public sealed class IndexFromFractional : NaturalEnvelope
{
	public IndexFromFractional(IFractional fractional) : base
	(
		new NaturalOfFunction(
			() => Function(fractional))
			
	)
	{
	}

	private static INaturalInteger Function(IFractional fractional)
	{
		if (new IsGreaterThanZero(fractional).State)
			return new NaturalFromInt32(0);
		return new NaturalFromInt32(1);
	}
}