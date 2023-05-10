using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using BooleanOfFunction = Tumbleweed.Booleans.OfSystem.BooleanOfFunction;

namespace Tumbleweed.Objects.Equality.ByValues;

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