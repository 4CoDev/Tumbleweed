using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;
using VertexIndicesOfTriangles =
	DotGod.Geometry.Spatial.Graphical.Vertex.Index.FromArrayMesh.FromSurface.IndicesOfTriangles;

namespace DotGod.Geometry.Spatial.Graphical.Polygon.Triangle.FromGodot.
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