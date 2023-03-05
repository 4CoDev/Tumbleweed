using Godot;
using TumbleGD.Geometrics.Graphical.MeshDataTools.FromArrayMesh;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.FromArrayMesh.
	FromSurface;

public sealed class VertexWithIndex : VertexEnvelope
{
	public VertexWithIndex
	(
		IScalar<ArrayMesh> arrayMesh,
		IScalar<Int32> surface,
		IScalar<Int32> vertex
	) : base
	(
		new FromMeshDataTool.VertexWithIndex(
			new MeshDataToolFromSurface(arrayMesh, surface),
			vertex)
	)
	{
	}
}