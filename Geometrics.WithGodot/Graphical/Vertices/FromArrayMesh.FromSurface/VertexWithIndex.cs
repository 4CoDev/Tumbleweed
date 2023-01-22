using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Geometrics.WithGodot.Graphical.MeshDataTools.FromArrayMesh;
using Tumbleweed.Scalars;
using Godot;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.FromArrayMesh.
	FromSurface;

public sealed class VertexWithIndex : VertexEnvelope
{
	public VertexWithIndex
	(
		IScalar<ArrayMesh> arrayMesh,
		IScalar<int> surface,
		IScalar<int> vertex
	) : base
	(
		new FromMeshDataTool.VertexWithIndex(
			new MeshDataToolFromSurface(arrayMesh, surface),
			vertex)
	)
	{
	}
}