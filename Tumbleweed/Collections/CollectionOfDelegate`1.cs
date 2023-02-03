using System.Collections;
using Tumbleweed.Scalars;

namespace Tumbleweed.Collections;

public sealed class CollectionOfDelegate<T> : CollectionEnvelope<T>
{
	public CollectionOfDelegate(Func<ICollection<T>> @delegate) : base
	(
		new CollectionOfScalar<T>(
			new ScalarOfDelegate<ICollection<T>>(@delegate))
	)
	{
	}
}