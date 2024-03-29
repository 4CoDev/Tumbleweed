using Tumbleweed.Mathematics.Vector.Spatial.Generic.Property.Value;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.From.Enumerable;

public sealed class Aggregated<T> : Envelope<T>
{
	public Aggregated
	(
		SCG::IEnumerable<Any<T>> from,
		Any<T> seed,
		System::Func<Any<T>, Any<T>, Any<T>> expression
	) : this
	(
		from,
		seed,
		new Function::From.System
		<
			Any<T>,
			Any<T>,
			Any<T>
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Any<T>> from,
		Any<T> seed,
		Function::Any<Any<T>, Any<T>, Any<T>> expression
	) : base
	(
		new Actual<T>(
			new Tumbleweed.Property.Output.From.Enumerable.Aggregated<Any<T>>(
				from,
				seed,
				expression))
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Any<T>> from,
		System::Func<Any<T>, Any<T>, Any<T>> expression
	) : this
	(
		from,
		new Function::From.System
		<
			Any<T>,
			Any<T>,
			Any<T>
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Any<T>> from,
		Function::Any<Any<T>, Any<T>, Any<T>> expression
	) : base
	(
		new Actual<T>(
			new Tumbleweed.Property.Output.From.Enumerable.Aggregated<Any<T>>(
				from,
				expression))
	)
	{
	}
}