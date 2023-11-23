using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Boolean.From.Enumerable;
using Envelope = Tumbleweed.Mathematics.Boolean.Envelope;

namespace Tumbleweed.Mathematics.Comparison.Boolean.Any.Is;

public sealed class True : Envelope
{
	public True(params Mathematics.Boolean.Any[] booleans) : this
	(
		new Concatenated<Mathematics.Boolean.Any>(booleans)
	)
	{
	}
	
	public True(IEnumerable<Mathematics.Boolean.Any> booleans) : base
	(
		new Aggregated(
			booleans,
			Expression)
	)
	{
	}
	
	private static Mathematics.Boolean.Any Expression
	(
		Mathematics.Boolean.Any first,
		Mathematics.Boolean.Any second
	) =>
	(
		new Either.Is.True(first, second)
	);
}