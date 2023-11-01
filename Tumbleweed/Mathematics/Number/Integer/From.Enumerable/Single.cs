using Tumbleweed.Mathematics.Number.Integer.Property.Value;
using Tumbleweed.Property.Output.From.Enumerable;

namespace Tumbleweed.Mathematics.Number.Integer.From.Enumerable;

public sealed class Single : Tumbleweed.Mathematics.Number.Integer.Envelope
{
	public Single
	(
		IEnumerable<Any> enumerable
	) : base
	(
		new Actual(
			new Single<Any>(enumerable))
	)
	{
	}
}