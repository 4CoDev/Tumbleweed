using Tumbleweed.Mathematics.Vector.Spatial.Generic.Property.Value;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.From.Enumerable;

public sealed class Aggregated<TFrom, TTo> : Envelope<TTo>
{
	public Aggregated
	(
		SCG::IEnumerable<TFrom> from,
		Any<TTo> seed,
		System::Func<Any<TTo>, TFrom, Any<TTo>> expression
	) : this
	(
		from,
		seed,
		new Function::From.System
		<
			Any<TTo>,
			TFrom,
			Any<TTo>
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<TFrom> from,
		Any<TTo> seed,
		Function::Any<Any<TTo>, TFrom, Any<TTo>> 
		expression
	) : base
	(
		new Actual<TTo>(
			new Tumbleweed.Property.Output.From.Enumerable.Aggregated<TFrom, Any<TTo>>(
				from,
				seed,
				expression))
	)
	{
	}
}