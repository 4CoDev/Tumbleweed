using DotGod.Geometry.Spatial.Convex.Vertex.Godot;
using DotGod.Vector.Spatial.Point;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Convex.Vertex;

public sealed class VerticesFromGodot : EnumerableEnvelope<IVertex>
{
	public VerticesFromGodot
	(
		ConvexPolygonShape3D shape
	) : this
	(
		new ScalarValue<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public VerticesFromGodot
	(
		IScalar<ConvexPolygonShape3D> shape
	) : base
	(
		new VerticesWithTranslations(
			new SpatialsFromVectors3(
				new VerticesFromMesh(shape)))
	)
	{
	}
}