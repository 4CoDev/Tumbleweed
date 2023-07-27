using Boolean = Tumbleweed.Boolean;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Comparison = Tumbleweed.Boolean.Comparison;

namespace Tumbleweed.Boolean.Comparison.All.Are;

public sealed class Equal : Boolean::Envelope
{
	public Equal(params Boolean::Any[] array) : this
	(
		new Enumerable::Concatenated<Boolean::Any>(array)
	)
	{
	}

	public Equal
	(
		SCG::IEnumerable<Boolean::Any> enumerable,
		Boolean::Any specific
	) : this
	(
		new Enumerable::Appended<Boolean::Any>(
			enumerable,
			specific)
	)
	{
	}
	
	public Equal
	(
		SCG::IEnumerable<Boolean::Any> enumerable
	) : base
	(
		new Boolean::From.Enumerable.Aggregated(
			enumerable,
			Expression)
	)
	{
	}
	
	private static Boolean::Any Expression
	(
		Boolean::Any first,
		Boolean::Any second
	) =>
	(
		new Comparison::Both.Are.Equal(first, second)
	);
}