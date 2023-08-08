using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.With.Material.Set;

public sealed class One : Any<Godot.SurfaceTool>
{
	public One
	(
		Any<Godot.SurfaceTool> origin,
		Any<Godot.Material> material
	)
	{
		this.origin = origin;
		this.material = material;
	}

	public Godot.SurfaceTool Value
	{
		get
		{
			Godot.SurfaceTool result = origin.Value;
			result.SetMaterial(material.Value);
			return result;
		}
	}

	private readonly Any<Godot.SurfaceTool> origin;
	
	private readonly Any<Godot.Material> material;
}