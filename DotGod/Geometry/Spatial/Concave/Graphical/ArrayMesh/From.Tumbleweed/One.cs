using DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.From.SurfaceTool;
using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.From.Tumbleweed;

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
