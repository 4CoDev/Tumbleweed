using Godot;
using TumbleGD.Geometrics.Graphical.Meshes.MeshDataTools.FromArrayMesh;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.FromArrayMesh.
	FromSurface;

public sealed class VertexWithIndex : VertexEnvelope
{
	public VertexWithIndex
	(
		IScalar<ArrayMesh> mesh,
		Int32 surface,
		Int32 vertex
	) : this
	(
		mesh,
		new ScalarOfValue<Int32>(surface),
		new ScalarOfValue<Int32>(vertex)
	)
	{
	}
	
	public VertexWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		Int32 vertex
	) : this
	(
		mesh,
		surface,
		new ScalarOfValue<Int32>(vertex)
	)
	{
	}
	
	public VertexWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IScalar<Int32> vertex
	) : base
	(
		new FromMeshDataTool.VertexWithIndex(
			new MeshDataToolFromSurface(mesh, surface),
			vertex)
	)
	{
	}
}