using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using TWMesh = Tumbleweed.Geometry.Spatial.Convex.Mesh;
using GodotMesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.From.Tumbleweed;

public sealed class One : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public One(TWMesh::Any mesh) : base
	(
		new GodotMesh::With.Vertex.Whole.Enumerable(
			new TWMesh::Member.Vertex.Enumerable(mesh))
	)
	{
	}
}