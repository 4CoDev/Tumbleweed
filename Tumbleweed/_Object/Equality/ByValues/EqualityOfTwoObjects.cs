using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;
using BooleanOfFunction = Tumbleweed._Boolean.OfSystem.BooleanOfFunction;

namespace Tumbleweed._Object.Equality.ByValues;

public sealed class EqualityOfTwoObjects : BooleanEnvelope
{
	public EqualityOfTwoObjects
	(
		Object first,
		Object second
	) : base
	(
		new BooleanFromSystem(
			new BooleanOfFunction(
				() => first.Equals(second)))
	)
	{
	}
}