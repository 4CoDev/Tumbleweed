using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Equality.ByValues;

public sealed class TwoNullableObjects : BitEnvelope
{
	public TwoNullableObjects
	(
		object? first,
		object? second
	) : base
	(
		new BitOfDelegate(
			() => Function(first, second))
	)
	{
	}

	private static IBit Function(object? first, object? second) =>
	(
		new BitFromBoolean(
			first == second ||
			first != null && second != null &&
			first.Equals(second))
	);
}