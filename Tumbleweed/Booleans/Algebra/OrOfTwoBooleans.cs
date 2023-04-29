using Tumbleweed.Booleans.FromSystem;

namespace Tumbleweed.Booleans.Algebra;

public sealed class OrOfTwoBooleans : BooleanEnvelope
{
	public OrOfTwoBooleans(IBoolean first, IBoolean second) : base
	(
		new BooleanFromSystem(
			new OfSystem.BooleanOfFunction(
				() => first.State || second.State))
	)
	{
	}
}