using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using SCG = System.Collections.Generic;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Binary;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Geometry.Spatial.Vertex.From.Enumerable;

public sealed class Aggregated : Vertex::Envelope
{
	public Aggregated
	(
		SCG::IEnumerable<Vertex::Any> from,
		Vertex::Any seed,
		System::Func<Vertex::Any, Vertex::Any, Vertex::Any> expression
	) : this
	(
		from,
		seed,
		new Function::From.System
		<
			Vertex::Any,
			Vertex::Any,
			Vertex::Any
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Vertex::Any> from,
		Vertex::Any seed,
		Function::Any<Vertex::Any, Vertex::Any, Vertex::Any> expression
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
		SCG::IEnumerable<Vertex::Any> from,
		System::Func<Vertex::Any, Vertex::Any, Vertex::Any> expression
	) : this
	(
		from,
		new Function::From.System
		<
			Vertex::Any,
			Vertex::Any,
			Vertex::Any
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		SCG::IEnumerable<Vertex::Any> from,
		Function::Any<Vertex::Any, Vertex::Any, Vertex::Any> expression
	) : base
	(
		new Vertex::Scalar.Value(
			new Tumbleweed.Scalar.Immutable.From.Enumerable.Aggregated<Vertex::Any>(
				from,
				expression))
	)
	{
	}
}