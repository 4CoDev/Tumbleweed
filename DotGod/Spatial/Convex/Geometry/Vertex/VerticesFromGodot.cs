using DotGod.Spatial.Convex.Geometry.Vertex.Godot;
using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Geometry.Vertex;

namespace DotGod.Spatial.Convex.Geometry.Vertex;

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