using DotGod.Geometry.Stereometry.Graphical.Mesh;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.ArrayMesh.From.Tumbleweed;

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
