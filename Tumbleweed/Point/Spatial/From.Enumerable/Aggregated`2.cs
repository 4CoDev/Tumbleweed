using Point = Tumbleweed.Point.Spatial;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.From.Enumerable;

public sealed class Aggregated<TFrom, TTo> : Point::Envelope<TTo>
{
	public Aggregated
	(
		SCG::IEnumerable<TFrom> from,
		Point::Any<TTo> seed,
		System::Func<Point::Any<TTo>, TFrom, Point::Any<TTo>> expression
	) : this
	(
		from,
		seed,
		new Function::From.System
		<
			Point::Any<TTo>,
			TFrom,
			Point::Any<TTo>
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
		Point::Any<TTo> seed,
		Function::Any<Point::Any<TTo>, TFrom, Point::Any<TTo>> 
		expression
	) : base
	(
		new Point::Scalar.Value<TTo>(
			new Scalar::From.Enumerable.Aggregated<TFrom, Point::Any<TTo>>(
				from,
				seed,
				expression))
	)
	{
	}
}