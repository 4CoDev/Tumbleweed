using Boolean = Tumbleweed.Boolean;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Comparison = Tumbleweed.Boolean.Comparison;
using Literal = Tumbleweed.Boolean.Literal;

namespace Tumbleweed.Boolean.Comparison.All.Are;

public sealed class False : Boolean::Envelope
{
	public False(params Boolean::Any[] array) : this
	(
		new Enumerable::Concatenated<Boolean::Any>(array)
	)
	{
	}
	
	public False
	(
		SCG::IEnumerable<Boolean::Any> enumerable
	) : base
	(
		new Comparison::All.Are.Equal(
			enumerable,
			new Literal::False())
	)
	{
	}
}