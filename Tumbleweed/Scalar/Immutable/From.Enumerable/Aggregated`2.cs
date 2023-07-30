using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.From.Enumerable;

public sealed class Aggregated<TFrom, TAccumulate>
	: Immutable::Envelope<TAccumulate>
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
		(
			expression
		)
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
		new Immutable::Function.Result.Actual<TAccumulate>(
			() => from.Aggregate(seed, expression.ResultWith))
	)
	{
	}
}