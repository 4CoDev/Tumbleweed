using System.Collections;
using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.Equality;

public sealed class EqualityOfTwoEnumerables : BooleanEnvelope
{
	public EqualityOfTwoEnumerables
	(
		Object first,
		Object second
	) : this
	(
		new ObjectAsType<IEnumerable>(first),
		new ObjectAsType<IEnumerable>(second)
	)
	{
	}
	
	public EqualityOfTwoEnumerables
	(
		IScalar<IEnumerable> first,
		IScalar<IEnumerable> second
	) : base
	(
		new BooleanOfFunction(
			() => Function(first.Value, second.Value))
	)
	{
	}

	private static IBoolean Function
	(
		IEnumerable first,
		IEnumerable second
	) =>
	(
		Function(
			first.Cast<Object>(),
			second.Cast<Object>())
	);
	
	private static IBoolean Function
	(
		IEnumerable<Object> first,
		IEnumerable<Object> second
	) =>
	(
		new BooleanFromSystem(
			first.SequenceEqual(second))
	);
}