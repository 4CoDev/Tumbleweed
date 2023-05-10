using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;

namespace Tumbleweed.Objects.Equality.ByReference;

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