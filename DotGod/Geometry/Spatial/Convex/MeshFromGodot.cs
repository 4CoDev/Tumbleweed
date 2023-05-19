using DotGod.Geometry.Spatial.Convex.Vertices;
using Godot;
using Tumbleweed.Geometry.Spatial.Convex;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Convex;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(ConvexPolygonShape3D shape) : this
	(
		new ScalarValue<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public MeshFromGodot
	(
		IScalar<ConvexPolygonShape3D> shape
	) : base
	(
		new MeshWithVertices(
			new VerticesFromGodot(shape))
	)
	{
	}
}