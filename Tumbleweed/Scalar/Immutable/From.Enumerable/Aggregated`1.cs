using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Scalar.Immutable.From.Enumerable;

public sealed class Aggregated<T> : Immutable::Envelope<T>
{
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		T seed,
		System::Func<T, T, T> expression
	) : this
	(
		from,
		seed,
		new Function::From.System<T, T, T>(expression)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		T seed,
		Function::Any<T, T, T> expression
	) : base
	(
		new Immutable::From.Enumerable.Aggregated<T, T>(
			from,
			seed, 
			expression)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		System::Func<T, T, T> expression
	) : this
	(
		from,
		new Function::From.System<T, T, T>(expression)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		Function::Any<T, T, T> expression
	) : base
	(
		new Immutable::Function.Result.Actual<T>(
			() => from.Aggregate(expression.ResultWith))
	)
	{
	}
}