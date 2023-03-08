using Tumbleweed.Scalars;

namespace Tumbleweed.Existence;

public sealed class NullableAsExistence<T> : ScalarEnvelope<IExistence<T>?>
{
	public NullableAsExistence(Object? @object) : base
	(
		new NullableAsType<IExistence<T>>(@object)
	)
	{
	}
}