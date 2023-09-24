using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;
using Vertex = Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.From.Enumerable;

public sealed class Aggregated : Envelope
{
	public Aggregated
	(
		SCG::IEnumerable<Any> from,
		Any seed,
		System::Func<Any, Any, Any> expression
	) : this
	(
		from,
		seed,
		new Function::From.System
		<
			Any,
			Any,
			Any
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Any> from,
		Any seed,
		Function::Any<Any, Any, Any> expression
	) : base
	(
		new Vertex::Scalar.Value(
			new Tumbleweed.Scalar.Immutable.From.Enumerable.Aggregated<Any>(
				from,
				seed,
				expression))
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Any> from,
		System::Func<Any, Any, Any> expression
	) : this
	(
		from,
		new Function::From.System
		<
			Any,
			Any,
			Any
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Any> from,
		Function::Any<Any, Any, Any> expression
	) : base
	(
		new Vertex::Scalar.Value(
			new Tumbleweed.Scalar.Immutable.From.Enumerable.Aggregated<Any>(
				from,
				expression))
	)
	{
	}
}