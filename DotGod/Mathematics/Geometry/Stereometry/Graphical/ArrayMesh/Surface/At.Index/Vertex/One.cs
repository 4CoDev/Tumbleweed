using DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.
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
		new DotGod.Geometry.Stereometry.Concave.Graphical.MeshDataTool.Vertex.At.One(
			new MeshDataTool.One(mesh, surface),
			vertex)
	)
	{
	}
}