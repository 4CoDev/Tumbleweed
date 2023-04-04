using Tumbleweed.Elements;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfElement<T> : EnumerableEnvelope<T>
{
	public EnumerableOfElement
	(
		IElement<IEnumerable<T>> element
	) : base
	(
		new EnumerableOfScalar<T>(
			new ValueOfElement<IEnumerable<T>>(element))
	)
	{
	}
}