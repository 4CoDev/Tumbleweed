using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.From.Tumbleweed;

public sealed class One : Envelope<Godot.ArrayMesh>
{
	public One(Any mesh) : base
	(
		new SurfaceTool.One(
			new Graphical.SurfaceTool.From.Mesh.One(mesh))
	)
	{
	}
}
