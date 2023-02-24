using Godot;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace Tumbleweed.Equality.ByString;

public sealed class EqualityOfTwoNullables : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		object? first,
		object? second
	) : base
	(
		new BitOfDelegate(
			() => Delegate(first, second))
	)
	{
	}

	private static IBit Delegate
	(
		object? first,
		object? second
	)
	{
		if (first != null && second != null)
		{
			return new EqualityOfTwoObjects(first, second);
		}
		return new ByReference.EqualityOfTwoNullables(first, second);
	}
}