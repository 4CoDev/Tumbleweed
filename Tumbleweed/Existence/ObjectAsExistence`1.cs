using Tumbleweed.Scalars;

namespace Tumbleweed.Existence;

public sealed class ObjectAsExistence<T> : ExistenceEnvelope<T>
{
	public ObjectAsExistence(Object @object) : base
	(
		new ExistenceOfScalar<T>(
			new ValueAsType<IExistence<T>>(@object))
	)
	{
	}
}