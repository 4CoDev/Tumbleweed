using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Linear.System.From.Enumerable;

public sealed class One<T> : Property::Envelope<T[]>
{
	public One(SCG::IEnumerable<T> enumerable) : base
	(
		new Property::Function.Result.Actual<T[]>(
			enumerable.ToArray)
	)
	{
	}
}