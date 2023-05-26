using System.Collections;

namespace Tumbleweed._Enumerable;

public sealed class ElementsAsType<T> : EnumerableEnvelope<T>
{
	public ElementsAsType(IEnumerable enumerable) : base
	(
		new EnumerableOfFunction<T>(enumerable.Cast<T>)
	)
	{
	}
}