using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using VertexIndicesOfTriangles =
	DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.FromSurface.IndicesOfTriangles;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.
	FromSurface;

public sealed class TrianglesOfSurface
	: EnumerableEnvelope<IPolygon>
{
	public TrianglesOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	) : base
	(
		new TrianglesWithVertexIndices(
			mesh,
			surface,
			new VertexIndicesOfTriangles(mesh, surface))
	)
	{
	}
}