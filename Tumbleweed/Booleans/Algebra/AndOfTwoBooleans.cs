using Tumbleweed.Booleans.FromSystem;

namespace Tumbleweed.Booleans.Algebra;

public sealed class AndOfTwoBooleans : BooleanEnvelope
{
	public AndOfTwoBooleans(IBoolean first, IBoolean second) : base
	(
		new BooleanFromSystem(
			new OfSystem.BooleanOfFunction(
				() => first.State && second.State))
	)
	{
	}
}