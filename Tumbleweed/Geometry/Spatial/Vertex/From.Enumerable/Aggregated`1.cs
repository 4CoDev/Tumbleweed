using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Geometry.Spatial.Vertex.From.Enumerable;

public sealed class Aggregated<T> : Vertex::Envelope
{
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		Vertex::Any seed,
		System::Func<Vertex::Any, T, Vertex::Any> expression
	) : this
	(
		from,
		seed,
		new Function::From.System<Vertex::Any, T, Vertex::Any>(
			expression)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<T> from,
		Vertex::Any seed,
		Function::Any<Vertex::Any, T, Vertex::Any> 
		expression
	) : base
	(
		new Vertex::Scalar.Value(
			new Scalar::From.Enumerable.Aggregated<T, Vertex::Any>(
				from,
				seed,
				expression))
	)
	{
	}
}