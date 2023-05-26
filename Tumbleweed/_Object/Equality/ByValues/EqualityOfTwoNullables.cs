using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;

namespace Tumbleweed._Object.Equality.ByValues;

public sealed class EqualityOfTwoNullables : BooleanEnvelope
{
	public EqualityOfTwoNullables
	(
		Object? first,
		Object? second
	) : base
	(
		new BooleanOfFunction(
			() => Function(first, second))
	)
	{
	}

	private static IBoolean Function(Object? first, Object? second) =>
	(
		new BooleanFromSystem(
			first == second ||
			first != null && second != null &&
			first.Equals(second))
	);
}