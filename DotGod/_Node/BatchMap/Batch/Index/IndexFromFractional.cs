using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.FromSystem;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace DotGod._Node.BatchMap.Batch.Index;

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