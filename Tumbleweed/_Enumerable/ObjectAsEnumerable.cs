using System.Collections;
using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable;

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