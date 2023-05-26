using Tumbleweed._Boolean.FromSystem;

namespace Tumbleweed._Boolean.Algebra;

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