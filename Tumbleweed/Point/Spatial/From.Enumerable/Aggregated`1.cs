using Point = Tumbleweed.Point.Spatial;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.From.Enumerable;

public sealed class Aggregated<T> : Point::Envelope<T>
{
	public Aggregated
	(
		SCG::IEnumerable<Point::Any<T>> from,
		Point::Any<T> seed,
		System::Func<Point::Any<T>, Point::Any<T>, Point::Any<T>> expression
	) : this
	(
		from,
		seed,
		new Function::From.System
		<
			Point::Any<T>,
			Point::Any<T>,
			Point::Any<T>
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Point::Any<T>> from,
		Point::Any<T> seed,
		Function::Any<Point::Any<T>, Point::Any<T>, Point::Any<T>> expression
	) : base
	(
		new Point::Scalar.Value<T>(
			new Scalar::From.Enumerable.Aggregated<Any<T>>(
				from,
				seed,
				expression))
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Point::Any<T>> from,
		System::Func<Point::Any<T>, Point::Any<T>, Point::Any<T>> expression
	) : this
	(
		from,
		new Function::From.System
		<
			Point::Any<T>,
			Point::Any<T>,
			Point::Any<T>
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Point::Any<T>> from,
		Function::Any<Point::Any<T>, Point::Any<T>, Point::Any<T>> expression
	) : base
	(
		new Point::Scalar.Value<T>(
			new Scalar::From.Enumerable.Aggregated<Point::Any<T>>(
				from,
				expression))
	)
	{
	}
}