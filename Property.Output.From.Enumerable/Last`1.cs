using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Property.Output.From.Enumerable;

public sealed class Last<T> : Property::Envelope<T>
{
	public Last(SCG::IEnumerable<T> enumerable) : base
	(
		new Property::Function.Result.Actual<T>(
			enumerable.Last)
	)
	{
	}
}