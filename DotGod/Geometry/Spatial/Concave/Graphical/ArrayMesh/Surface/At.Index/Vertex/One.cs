using DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.MeshDataTool;
using DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.
	Vertex;

public sealed class One : Envelope
{
	public One
	(
		Any<Godot.ArrayMesh> mesh,
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
	
	public One
	(
		Any<Godot.ArrayMesh> mesh,
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
	
	public One
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface,
		Any<Int32> vertex
	) : base
	(
		new Graphical.MeshDataTool.Vertex.At.One(
			new MeshDataTool.One(mesh, surface),
			vertex)
	)
	{
	}
}