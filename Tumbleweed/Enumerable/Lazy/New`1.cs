using Enumerable = Tumbleweed.Enumerable;
using Property = Tumbleweed.Property;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Lazy;

public sealed class New<T> : Enumerable::Envelope<T>
{
	public New(IEnumerable<T> enumerable) : base
	(
		new Enumerable::Property.Value<T>(
			new Tumbleweed.Property.Output.Function.Result.Lazy<IEnumerable<T>>(
				() => new SCG::List<T>(enumerable)))
	)
	{
	}
}