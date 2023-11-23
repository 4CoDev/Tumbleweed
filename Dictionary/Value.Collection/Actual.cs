using Collection = Tumbleweed.Collection;
using System = System;

namespace Tumbleweed.Dictionary.Value.Collection;

public sealed class Actual<T> : Collection::Envelope<T>
{
	public Actual
	(
		IDictionary<System::Object, T> dictionary
	) : base
	(
		new Collection::Function.Result.Actual<T>(
			() => dictionary.Values)
	)
	{
	}
}