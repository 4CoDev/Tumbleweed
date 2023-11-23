using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Property.Output.From.Enumerable;

public sealed class First<T> : Property::Envelope<T>
{
	public First(SCG::IEnumerable<T> enumerable) : base
	(
		new Property::Function.Result.Actual<T>(
			enumerable.First)
	)
	{
	}
}