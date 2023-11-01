using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Property.Output.From.Enumerable;

public sealed class Aggregated<TFrom, TAccumulate>
	: Property::Envelope<TAccumulate>
{
	public Aggregated
	(
		SCG::IEnumerable<TFrom> from,
		TAccumulate seed,
		System::Func<TAccumulate, TFrom, TAccumulate> expression
	) : this
	(
		from,
		seed,
		new Function::From.System
		<
			TAccumulate,
			TFrom,
			TAccumulate
		>
		(expression)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<TFrom> from,
		TAccumulate seed,
		Function::Any<TAccumulate, TFrom, TAccumulate> expression
	) : base
	(
		new Property::Function.Result.Actual<TAccumulate>(
			() => from.Aggregate(seed, expression.ResultWith))
	)
	{
	}
}