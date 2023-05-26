using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;

namespace Tumbleweed._Object.Equality.ByReference;

public sealed class EqualityOfTwoNullables : BooleanEnvelope
{
	public EqualityOfTwoNullables
	(
		Object? first,
		Object? second
	) : base
	(
		new BooleanOfFunction(
			() => new BooleanFromSystem(
				ReferenceEquals(first, second)))
	)
	{
	}
		
}