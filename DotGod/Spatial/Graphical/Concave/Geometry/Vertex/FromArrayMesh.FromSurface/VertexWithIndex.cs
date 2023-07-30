using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._MeshDataTool.FromArrayMesh;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.FromArrayMesh.
	FromSurface;

public sealed class VertexWithIndex : VertexEnvelope
{
	public VertexWithIndex
	(
		Any<ArrayMesh> mesh,
		Int32 surface,
		Int32 vertex
	) : this
	(
		mesh,
		new Value<Int32>(surface),
		new Value<Int32>(vertex)
	)
	{
	}
	
	public VertexWithIndex
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface,
		Int32 vertex
	) : this
	(
		mesh,
		surface,
		new Value<Int32>(vertex)
	)
	{
	}
	
	public VertexWithIndex
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface,
		Any<Int32> vertex
	) : base
	(
		new FromMeshDataTool.VertexWithIndex(
			new MeshDataToolFromSurface(mesh, surface),
			vertex)
	)
	{
	}
}