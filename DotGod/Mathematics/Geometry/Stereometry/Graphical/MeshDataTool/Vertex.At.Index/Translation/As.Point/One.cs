using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.MeshDataTool.Vertex.At.Index.Translation.As.Point;

public sealed class One : Envelope<Any>
{
	public One
	(
		Tumbleweed.Property.Output.Any<Godot.MeshDataTool> tool,
		Tumbleweed.Mathematics.Number.Natural.Any vertex
	) : this
	(
		tool,
		new Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed.One(vertex)
	)
	{
	}
	
	public One
	(Tumbleweed.Property.Output.Any<Godot.MeshDataTool> mesh, Tumbleweed.Property.Output.Any<Int32> vertex
	) : base
	(
		new Mathematics.Vector.Spatial.Tumbleweed.From.Godot.One(
			new Vector.One(mesh, vertex))
	)
	{
	}
}