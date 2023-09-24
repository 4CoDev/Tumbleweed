using Enumerable = Tumbleweed.Enumerable;
using Envelope = Tumbleweed.Mathematics.Boolean.Envelope;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Comparison.Boolean.All.Are;

public sealed class False : Envelope
{
	public False(params Mathematics.Boolean.Any[] array) : this
	(
		new Enumerable::Concatenated<Mathematics.Boolean.Any>(array)
	)
	{
	}
	
	public False
	(
		SCG::IEnumerable<Mathematics.Boolean.Any> enumerable
	) : base
	(
		new Equal(
			enumerable,
			new Mathematics.Boolean.Literal.False())
	)
	{
	}
}