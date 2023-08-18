using Enumerable = Tumbleweed.Enumerable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using TWVertex = Tumbleweed.Geometry.Spatial.Vertex;
using DGVertex = DotGod.Geometry.Spatial.Convex.Physical.Vertex;

namespace DotGod.Geometry.Spatial.Convex.Physical.Vertex.Member.Translation.Vector;

public sealed class Enumerable : Enumerable::Envelope<Godot::Vector3>
{
	public Enumerable
	(
		SCG::IEnumerable<TWVertex::Any> vertices
	) : base
	(
		new Enumerable::Selected
		<TWVertex::Any, Godot::Vector3>
		(
			vertices,
			Function
		)
	)
	{
	}
	
	private static Godot::Vector3 Function
	(
		TWVertex::Any vertex
	) =>
	(
		new DGVertex::Member.Translation.Vector.One(vertex).Value
	);
}