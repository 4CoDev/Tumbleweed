using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;
using Enumerable = Tumbleweed.Enumerable;
using Godot = Godot;
using SCG = System.Collections.Generic;

namespace DotGod.Geometry.Stereometry.Basic.Vertex.Member.Translation.Vector;

public sealed class Enumerable : Enumerable::Envelope<Godot::Vector3>
{
	public Enumerable
	(
		SCG::IEnumerable<Any> vertices
	) : base
	(
		new Enumerable::Selected
		<Any, Godot::Vector3>
		(
			vertices,
			Function
		)
	)
	{
	}
	
	private static Godot::Vector3 Function
	(
		Any vertex
	) =>
	(
		new One(vertex).Value
	);
}