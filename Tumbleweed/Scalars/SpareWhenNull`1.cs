using Tumbleweed.Nullability;

namespace Tumbleweed.Scalars;

public sealed class SpareWhenNull<T> : ScalarEnvelope<T>
{
	public SpareWhenNull
	(
		INullable<T> nullable,
		T spare
	) : this
	(
		nullable,
		new ScalarValue<T>(spare)
	)
	{
	}
	
	public SpareWhenNull
	(
		INullable<T> nullable,
		IScalar<T> spare
	) : base
	(
		new ResultOfFunction<T>(
			() => Function(nullable, spare))
	)
	{
	}

	private static T Function
	(
		INullable<T> nullable,
		IScalar<T> spare
	)
	{
		if (nullable.Existing.State) return nullable.Value;
		return spare.Value;
	}
}