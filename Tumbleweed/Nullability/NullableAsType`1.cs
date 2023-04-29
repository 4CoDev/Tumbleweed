using Tumbleweed.Booleans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullability;

public sealed class NullableAsType<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableAsType(INullable<Object> origin) : base
	(
		new NullableWithValues<T>(
			new ObjectAsType<T>(
				new ValueOfFunction<Object>(() => origin.Value)),
			new BooleanOfFunction(() => origin.Existing))
	)
	{
	}
}