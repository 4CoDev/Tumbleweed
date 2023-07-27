using Boolean = Tumbleweed.Boolean;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Comparison = Tumbleweed.Boolean.Comparison;
using Literal = Tumbleweed.Boolean.Literal;

namespace Tumbleweed.Boolean.Comparison.All.Are;

public sealed class True : Boolean::Envelope
{
	public True(params Boolean::Any[] array) : this
	(
		new Enumerable::Concatenated<Boolean::Any>(array)
	)
	{
	}
	
	public True
	(
		SCG::IEnumerable<Boolean::Any> enumerable
	) : base
	(
		new Comparison::All.Are.Equal(
			enumerable,
			new Literal::True())
	)
	{
	}
}