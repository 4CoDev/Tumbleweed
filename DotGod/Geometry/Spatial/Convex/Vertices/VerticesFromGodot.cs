using DotGod.Geometry.Spatial.Convex.Vertices.Godot;
using DotGod.Vectors.Spatial.Points;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometry.Spatial.Vertices;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Convex.Vertices;

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