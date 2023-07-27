using Tumbleweed.Enumerable;

namespace Tumbleweed.String.Spare.When.Null;

public sealed class Multiple : Envelope<Any>
{
	public Multiple
	(
		IEnumerable<System.String?> nullables,
		System.String spare
	) : this
	(
		new From.System.Nullable.Multiple(nullables),
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Any?> nullables,
		Any spare
	) : this
	(
		new Nullable.From.System.Multiple<Any>(nullables),
		spare
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Nullable.Any<Any>> nullables,
		Any spare
	) : base
	(
		new Selected<Nullable.Any<Any>, Any>(
			nullables,
			nullable => Expression(nullable, spare))
	)
	{
	}

	private static Any Expression
	(
		Nullable.Any<Any> nullable,
		Any spare
	) =>
	(
		new One(nullable, spare)
	);
}