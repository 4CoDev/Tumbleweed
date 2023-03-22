using System.Collections;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class ObjectAsEnumerable : EnumerableEnvelope
{
	public ObjectAsEnumerable(IScalar<Object> @object) : base
	(
		new EnumerableOfScalar(
			new ObjectAsType<IEnumerable>(@object))
	)
	{
	}
}