using Tumbleweed.Collection;
using Tumbleweed.Collection.Function.Result;
using System = System;

namespace Tumbleweed.Dictionary;

public sealed class ValuesOfDictionary<T> : Envelope<T>
{
	public ValuesOfDictionary
	(
		IDictionary<System::Object, T> dictionary
	) : base
	(
		new Actual<T>(
			() => dictionary.Values)
	)
	{
	}
}