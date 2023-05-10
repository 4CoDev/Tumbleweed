using Tumbleweed.Booleans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullables;

public sealed class NullableAsType<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableAsType(INullable<Object> origin) : base
	(
		new NullableWithValues<T>(
			new ObjectAsType<T>(
				new ResultOfFunction<Object>(() => origin.Value)),
			new BooleanOfFunction(() => origin.Existing))
	)
	{
	}
}