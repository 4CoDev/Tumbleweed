using Tumbleweed.Scalar.Immutable.From.Enumerable;
using Vertex = Tumbleweed.Geometry.Stereometry.Vertex;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Geometry.Stereometry.Vertex.From.Enumerable;

public sealed class Aggregated<T> : Envelope
{
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		Any seed,
		System::Func<Any, T, Any> expression
	) : this
	(
		from,
		seed,
		new Function::From.System<Any, T, Any>(
			expression)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		Any seed,
		Function::Any<Any, T, Any> 
		expression
	) : base
	(
		new Vertex::Scalar.Value(
			new Aggregated<T, Any>(
				from,
				seed,
				expression))
	)
	{
	}
}