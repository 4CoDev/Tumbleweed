using DotGod.Geometry.Spatial.Graphical.Mesh.PrimitiveType;
using Godot;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.SurfaceTool.From.Surface;

public sealed class Initial
	: Envelope<Godot.SurfaceTool>
{
	public Initial(Any<Material> material) : base
	(
		new With.Material.Set.One(
			new SurfaceTool.With.PrimitiveType.Set.One(new Triangles()),
			material)
	)
	{
	}
}