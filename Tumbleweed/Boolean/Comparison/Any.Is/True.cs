using Tumbleweed.Boolean.From.Enumerable;
using Tumbleweed.Enumerable;

namespace Tumbleweed.Boolean.Comparison.Any.Is;

public sealed class True : Envelope
{
	public True(params Boolean.Any[] booleans) : this
	(
		new Concatenated<Boolean.Any>(booleans)
	)
	{
	}
	
	public True(IEnumerable<Boolean.Any> booleans) : base
	(
		new Aggregated(
			booleans,
			Expression)
	)
	{
	}
	
	private static Boolean.Any Expression
	(
		Boolean.Any first,
		Boolean.Any second
	) =>
	(
		new Either.Is.True(first, second)
	);
}