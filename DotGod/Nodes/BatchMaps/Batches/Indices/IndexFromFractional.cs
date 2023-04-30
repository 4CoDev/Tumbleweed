using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.FromSystem;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;

namespace DotGod.Nodes.BatchMaps.Batches.Indices;

public sealed class IndexFromFractional : NaturalEnvelope
{
	public IndexFromFractional(IReal real) : base
	(
		new NaturalOfFunction(
			() => Function(real))
			
	)
	{
	}

	private static INatural Function(IReal real)
	{
		if (new IsGreaterThanZero(real).State)
			return new NaturalFromInt32(0);
		return new NaturalFromInt32(1);
	}
}