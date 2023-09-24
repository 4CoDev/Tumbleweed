using Tumbleweed.Mathematics.Boolean.From.Enumerable;
using Enumerable = Tumbleweed.Enumerable;
using Envelope = Tumbleweed.Mathematics.Boolean.Envelope;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Comparison.Boolean.All.Are;

public sealed class Equal : Envelope
{
	public Equal(params Mathematics.Boolean.Any[] array) : this
	(
		new Enumerable::Concatenated<Mathematics.Boolean.Any>(array)
	)
	{
	}

	public Equal
	(
		SCG::IEnumerable<Mathematics.Boolean.Any> enumerable,
		Mathematics.Boolean.Any specific
	) : this
	(
		new Enumerable::Appended<Mathematics.Boolean.Any>(
			enumerable,
			specific)
	)
	{
	}
	
	public Equal
	(
		SCG::IEnumerable<Mathematics.Boolean.Any> enumerable
	) : base
	(
		new Aggregated(
			enumerable,
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
		new Both.Are.Equal(first, second)
	);
}