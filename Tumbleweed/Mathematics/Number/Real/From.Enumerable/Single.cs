using Tumbleweed.Mathematics.Number.Real.Property;
using Tumbleweed.Property.Output.From.Enumerable;

namespace Tumbleweed.Mathematics.Number.Real.From.Enumerable;

public sealed class Single : Envelope
{
	public Single(IEnumerable<Any> enumerable) : base
	(
		new Value(
			new Single<Any>(enumerable))
	)
	{
	}
}