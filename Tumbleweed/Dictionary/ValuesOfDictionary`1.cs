using Tumbleweed._Collection;

namespace Tumbleweed.Dictionary;

public sealed class ValuesOfDictionary<T> : CollectionEnvelope<T>
{
	public ValuesOfDictionary
	(
		IDictionary<Object, T> dictionary
	) : base
	(
		new CollectionOfFunction<T>(
			() => dictionary.Values)
	)
	{
	}
}