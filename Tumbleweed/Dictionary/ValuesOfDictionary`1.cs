using Tumbleweed.Collection;
using System = System;

namespace Tumbleweed.Dictionary;

public sealed class ValuesOfDictionary<T> : CollectionEnvelope<T>
{
	public ValuesOfDictionary
	(
		IDictionary<System::Object, T> dictionary
	) : base
	(
		new CollectionOfFunction<T>(
			() => dictionary.Values)
	)
	{
	}
}